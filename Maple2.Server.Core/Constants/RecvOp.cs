﻿namespace Maple2.Server.Core.Constants;

public enum RecvOp : ushort {
    Null = 0x000,
    ResponseVersion = 0x0001,
    Patch = 0x0002,
    ResponseLogin = 0x0003,
    ResponseKey = 0x0004,
    Reconnect = 0x0005,
    Pong = 0x0006,
    ReconnectUnk = 0x0007,
    FinalizeReconnect = 0x0008,
    CharacterManagement = 0x0009,
    ResponseHeartbeat = 0x000A,
    RequestTimeSync = 0x000B,
    ResponseClientTickSync = 0x000C,
    RequestQuit = 0x000D,
    DynamicBanword = 0x000E,
    RequestLoadUgcMap = 0x000F,
    ResponseFieldEnter = 0x0010,
    UserChat = 0x0011,
    UserSync = 0x0012,
    Emote = 0x0013,
    RequestServerList = 0x0014,
    RequestItemCreate = 0x0015,
    ItemEquip = 0x0016,
    RequestItemInventory = 0x0017,
    RequestItemStorage = 0x0018,
    RequestItemUse = 0x0019,
    ItemExtraData = 0x001A,
    RequestItemPickup = 0x001C,
    RequestMesoPickup = 0x001D,
    CharacterInfo = 0x001E,
    Revival = 0x001F,
    Skill = 0x0020,
    StateSkill = 0x0021,
    NpcTalk = 0x0022,
    Beauty = 0x0023,
    RequestNpcCreate = 0x0024,
    Job = 0x0025,
    Vibrate = 0x0026,
    Breakable = 0x0027,
    Shop = 0x0028,
    Quest = 0x0029,
    Tombstone = 0x002A,
    RoomDungeon = 0x002B,
    Party = 0x002C,
    Mail = 0x002D,
    FunctionCube = 0x002E,
    Trigger = 0x002F,
    Buddy = 0x0030,
    InteractObject = 0x0031,
    InteractNpc = 0x0032,
    StateConsumeEp = 0x0033,
    StateFallDamage = 0x0034,
    GuideObjectSync = 0x0035,
    RequestSetCraftMode = 0x0036,
    RequestCube = 0x0037,
    RequestApartment = 0x0038,
    Ugc = 0x0039,
    MeretMarket = 0x003A,
    KeyTable = 0x003B,
    Channel = 0x003C,
    Liftable = 0x003D,
    MyInfo = 0x003E,
    RelocateWorld = 0x003F,
    ItemFusion = 0x0040,
    RequestRide = 0x0041,
    RideSync = 0x0042,
    FittingDoll = 0x0043,
    BonusGame = 0x0044,
    ResolvePenalty = 0x0045,
    TakeBoat = 0x0046,
    Achieve = 0x0047,
    BadgeEquip = 0x0048,
    RequestTaxi = 0x0049,
    Trade = 0x004A,
    RequestWorldmap = 0x004B,
    Guild = 0x004C,
    GroupChat = 0x004D,
    RequestHomeBank = 0x004E,
    RequestHomeDoctor = 0x004F,
    Ah = 0x0050,
    SetDebugMode = 0x0051,
    RequestHome = 0x0052,
    RequestReport = 0x0053,
    FurnishingStorage = 0x0054,
    RequestMoveEventField = 0x0055,
    LogSend = 0x0056,
    DpsMode = 0x0057,
    GuideRecord = 0x0058,
    Rank = 0x0059,
    RequestSkipTutorial = 0x005A,
    ItemDismantle = 0x005B,
    RideConsumeEp = 0x005C,
    RequestAdditionalEffect = 0x005D,
    RecallUser = 0x005E,
    RequestItemEnchant = 0x005F,
    BlackMarket = 0x0060,
    Gamble = 0x0061,
    Pvp = 0x0062,
    Maid = 0x0063,
    NewsNotification = 0x0064,
    SmartRecommendBilling = 0x0065,
    SystemShop = 0x0066,
    Attendance = 0x0067,
    PcBangBonus = 0x0068,
    MaidCraftItem = 0x0069,
    RequestUserEnv = 0x006A,
    Cash = 0x006B,
    Nametag = 0x006C,
    RequestMoveField = 0x006D,
    WaitingTicket = 0x006E,
    MatchParty = 0x006F,
    RecallScroll = 0x0070,
    PotentialAbility = 0x0071,
    EnchantScroll = 0x0072,
    GlobalPortal = 0x0073,
    Fishing = 0x0074,
    PlayInstrument = 0x0075,
    ChangeAttributes = 0x0076,
    ChangeAttributesScroll = 0x0077,
    TransferEnchant = 0x0078,
    RequestPet = 0x0079,
    RequestPetInventory = 0x007A,
    NoticeDialog = 0x007B,
    SkillMacro = 0x007C,
    Banword = 0x007D,
    CheckCharName = 0x007E,
    PlatformProtectPacket = 0x007F,
    PlatformAccountSafe = 0x0080,
    State = 0x0081,
    MesoMarket = 0x0082,
    GlobalFactor = 0x0083,
    SmartPush = 0x0084,
    PlayArcade = 0x0085,
    EnterEventField = 0x0086,
    CardReverseGame = 0x0087,
    RequestItemLock = 0x0088,
    ItemSocketSystem = 0x0089,
    CharacterAbility = 0x008A,
    Tutorial = 0x008B,
    ItemSocketScroll = 0x008C,
    ItemRepack = 0x008D,
    Mapleopoly = 0x008E,
    PremiumClub = 0x008F,
    HomeGame = 0x0091,
    Mastery = 0x0093,
    ConstructShop = 0x0094,
    Club = 0x0096,
    NexonArena = 0x0097,
    EventReward = 0x0098,
    NameChange = 0x0099,
    AttributePoint = 0x009A,
    ItemRepeat = 0x009B,
    ItemExchangeScroll = 0x009C,
    RequestTutorialItem = 0x009D,
    DungeonReward = 0x009E,
    ItemBillboard = 0x009F,
    TreasureMap = 0x00A0,
    ItemExtractionScroll = 0x00A1, // GlamourAnvil
    Mentor = 0x00A2,
    RequestSkillBookTree = 0x00A3,
    BuddyEmote = 0x00A4,
    BuddyBadge = 0x00A5,
    SyncWorld = 0x00A6,
    BirthdayCard = 0x00A7,
    SuperWorldChat = 0x00A8,
    Microgame = 0x00A9,
    StateReact = 0x00AA,
    TreeWatering = 0x00AB,
    Survival = 0x00AC,
    SpectateMushtopia = 0x00AD,
    Prestige = 0x00AE,
    Lapenshard = 0x00AF,
    Ugd = 0x00B0,
    WorldChampion = 0x00B1,
    ServerEnter = 0x00B2,
    MinimapPing = 0x00B3,
    // 0x00B4, CClientPlatformNexonAmerica sub_7F3AE0
    MsgBox = 0x00B5,
    Wardrobe = 0x00B6,
    SystemInfo = 0x00B7,
    SidePopup = 0x00B8,
    ChatSticker = 0x00B9,
    WebScreenshot = 0x00BA,
    FileHash = 0x00BB,
    Wedding = 0x00BC,
    WeddingBillboard = 0x00BD,
    LimitBreak = 0x00BE,
}
