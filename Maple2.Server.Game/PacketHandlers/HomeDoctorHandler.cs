﻿using System;
using Maple2.PacketLib.Tools;
using Maple2.Server.Core.Constants;
using Maple2.Server.Core.PacketHandlers;
using Maple2.Server.Core.Packets;
using Maple2.Server.Game.Packets;
using Maple2.Server.Game.Session;
using Microsoft.Extensions.Logging;

namespace Maple2.Server.Game.PacketHandlers;

public class HomeDoctorHandler : PacketHandler<GameSession> {
    public override ushort OpCode => RecvOp.REQUEST_HOME_DOCTOR;

    private const int DOCTOR_COST_MESO = 10000;

    public HomeDoctorHandler(ILogger<HomeDoctorHandler> logger) : base(logger) { }

    public override void Handle(GameSession session, IByteReader packet) {
        long time = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        if (session.Player.Value.Character.DoctorCooldown + Constant.HomeDoctorCallCooldown > time) {
            return;
        }

        // TODO: Error here? and how much should this cost.
        if (session.Currency.Meso < DOCTOR_COST_MESO) {
            return;
        }

        session.Player.Value.Character.DoctorCooldown = time;
        session.Currency.Meso -= DOCTOR_COST_MESO;
        session.Send(RevivalPacket.Confirm(session.Player));
        session.Send(HomeDoctor(time));
    }

    private static ByteWriter HomeDoctor(long time) {
        var pWriter = Packet.Of(SendOp.HOME_DOCTOR);
        pWriter.WriteLong(time);

        return pWriter;
    }
}
