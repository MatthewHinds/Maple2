﻿using Maple2.Server.Core.PacketHandlers;
using Maple2.Server.Game.Session;
using Microsoft.Extensions.Logging;

namespace Maple2.Server.Game.PacketHandlers;

public class LogSendHandler : LogSendHandler<GameSession> {
    public LogSendHandler(ILogger<LogSendHandler> logger) : base(logger) { }

    public override string ToString() => $"[0x{OpCode:X4}] Game.{GetType().Name}";
}