// C# Structs For Cboe Options Bzx Boe OrderEntry 2.10 protocol

///////////////////////////////////////////////////////////////////////
// Enum Values
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Application Message Type Values
/// </summary>
public enum ApplicationMessageType : byte {
    OrderAcknowledgment = 0x25,
    OrderRejected = 0x26,
    OrderModified = 0x27,
    OrderRestated = 0x28,
    UserModifyRejected = 0x29,
    OrderCancelled = 0x2A,
    CancelRejected = 0x2B,
    OrderExecution = 0x2C,
    TradeCancelOrCorrect = 0x2D,
    PurgeRejected = 0x48,
};

/// <summary>
///  Attributed Quote Values
/// </summary>
public enum AttributedQuote : byte {
    DoNotAttributeFirmExecutingBrokerId = (byte)'N',
    AttributeFirmExecutingBrokerId = (byte)'Y',
    AttributeClientIdOnly = (byte)'C',
    AttributeBothClearingFirmAndClientId = (byte)'Z',
};

/// <summary>
///  Base Liquidity Indicator Values
/// </summary>
public enum BaseLiquidityIndicator : byte {
    AddedLiquidity = (byte)'A',
    RemovedLiquidity = (byte)'R',
    RoutedToAnotherMarket = (byte)'X',
    AuctionOrUncrossing = (byte)'C',
};

/// <summary>
///  Cancel Orig On Reject Values
/// </summary>
public enum CancelOrigOnReject : byte {
    LeaveOriginalOrderAlone = (byte)'N',
    CancelOriginalOrderIfModificationFails = (byte)'Y',
};

/// <summary>
///  Cancel Reason Values
/// </summary>
public enum CancelReason : byte {
    Admin = (byte)'A',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    OrderWouldLockOrCrossNbbo = (byte)'L',
    OrderSizeExceeded = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    WaitingForFirstTrade = (byte)'Q',
    RoutingUnavailable = (byte)'R',
    FillWouldTradeThroughTheNbbo = (byte)'T',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    AddLiquidityOnlyOrderWouldRemove = (byte)'W',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    OnlyCloseTransactionsAccepted = (byte)'c',
    RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    MaxOpenOrdersCountExceeded = (byte)'o',
    ReserveReload = (byte)'r',
    RiskManagementRiskRootLevel = (byte)'s',
    WouldRemoveOnUnslide = (byte)'w',
    CrossedMarket = (byte)'x',
    OrderReceivedByCboeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
    RiskManagementEfidGroupLevel = (byte)'+',
};

/// <summary>
///  Cancel Reject Reason Values
/// </summary>
public enum CancelRejectReason : byte {
    Admin = (byte)'A',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    OrderWouldLockOrCrossNbbo = (byte)'L',
    OrderSizeExceeded = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    WaitingForFirstTrade = (byte)'Q',
    RoutingUnavailable = (byte)'R',
    FillWouldTradeThroughTheNbbo = (byte)'T',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    AddLiquidityOnlyOrderWouldRemove = (byte)'W',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    OnlyCloseTransactionsAccepted = (byte)'c',
    RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    MaxOpenOrdersCountExceeded = (byte)'o',
    ReserveReload = (byte)'r',
    RiskManagementRiskRootLevel = (byte)'s',
    WouldRemoveOnUnslide = (byte)'w',
    CrossedMarket = (byte)'x',
    OrderReceivedByCboeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
    RiskManagementEfidGroupLevel = (byte)'+',
};

/// <summary>
///  Capacity Values
/// </summary>
public enum Capacity : byte {
    Customer = (byte)'C',
    MarketMaker = (byte)'M',
    Firm = (byte)'F',
    ProfessionalCustomer = (byte)'U',
    NonCboeMarketMaker = (byte)'N',
    BrokerDealer = (byte)'B',
    JointBackOffice = (byte)'J',
};

/// <summary>
///  Display Indicator Values
/// </summary>
public enum DisplayIndicator : byte {
    DeterminedByPortLevelSetting = (byte)'V',
    PriceAdjust = (byte)'P',
    MultiplePriceAdjust = (byte)'m',
    RejectTheOrderIfItCannotBeBookedAndDisplayedWithoutAdjustment = (byte)'m',
};

/// <summary>
///  Ex Destination Values
/// </summary>
public enum ExDestination : byte {
    NyseArca = (byte)'A',
    NasdaqIse = (byte)'E',
    Miax = (byte)'F',
    MiaxPearl = (byte)'P',
    MiaxEmerald = (byte)'D',
    EdgxOptions = (byte)'G',
    C2 = (byte)'H',
    Box = (byte)'K',
    Nasdaq = (byte)'N',
    NasdaqBx = (byte)'S',
    NyseAmerican = (byte)'U',
    C1 = (byte)'W',
    NasdaqPhlx = (byte)'X',
    BzxOptions = (byte)'Z',
    NasdaqGemx = (byte)'g',
};

/// <summary>
///  Exec Inst Values
/// </summary>
public enum ExecInst : byte {
    IntermarketSweep = (byte)'f',
};

/// <summary>
///  Login Response Status Values
/// </summary>
public enum LoginResponseStatus : byte {
    LoginAccepted = (byte)'A',
    NotAuthorized = (byte)'N',
    SessionIsDisabled = (byte)'D',
    SessionInUse = (byte)'B',
    InvalidSession = (byte)'S',
    SequenceAheadInLoginMessage = (byte)'Q',
    InvalidUnitGivenInLoginMessage = (byte)'I',
    InvalidReturnBitFieldInLoginMessage = (byte)'F',
    InvalidLoginRequestMessageStructure = (byte)'M',
};

/// <summary>
///  Logout Reason Values
/// </summary>
public enum LogoutReason : byte {
    UserRequested = (byte)'U',
    EndOfDay = (byte)'E',
    Administrative = (byte)'A',
    ProtocolViolation = (byte)'!',
};

/// <summary>
///  Mass Cancel Lockout Values
/// </summary>
public enum MassCancelLockout : byte {
    NoLockout = (byte)'0',
    Lockout = (byte)'0',
};

/// <summary>
///  Message Type Values
/// </summary>
public enum MessageType : byte {
    LoginRequestMessage = 0x37,
    LogoutRequestMessage = 0x02,
    ClientHeartbeatMessage = 0x03,
    LoginResponseMessage = 0x24,
    LogoutMessage = 0x02,
    ServerHeartbeatMessage = 0x09,
    ReplayCompleteMessage = 0x13,
    NewOrderMessage = 0x38,
    CancelOrderMessage = 0x39,
    ModifyOrderMessage = 0x3A,
    QuoteUpdateMessage = 0x55,
    ShortQuoteUpdateMessage = 0x59,
    PurgeOrderMessage = 0x47,
    RiskResetMessage = 0x56,
    OrderAcknowledgmentMessage = 0x25,
    QuoteUpdateAcknowledgmentMessage = 0x25,
    OrderRejectedMessage = 0x26,
    CrossOrderRejectedMessage = 0x44,
    QuoteUpdateRejectedMessage = 0x58,
    OrderModifiedMessage = 0x27,
    OrderRestatedMessage = 0x28,
    QuoteRestatedMessage = 0x52,
    UserModifyRejectedMessage = 0x29,
    OrderCancelledMessage = 0x2a,
    QuoteCancelledMessage = 0x53,
    CancelRejectedMessage = 0x2B,
    QuoteExecutionMessage = 0x54,
    TradeCancelOrCorrectMessage = 0x2D,
    PurgeRejectedMessage = 0x48,
    ResetRiskAcknowledgmentMessage = 0x57,
    MassCancelAcknowledgmentMessage = 0x36,
};

/// <summary>
///  Modify Reject Reason Values
/// </summary>
public enum ModifyRejectReason : byte {
    Admin = (byte)'A',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    OrderWouldLockOrCrossNbbo = (byte)'L',
    OrderSizeExceeded = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    WaitingForFirstTrade = (byte)'Q',
    RoutingUnavailable = (byte)'R',
    FillWouldTradeThroughTheNbbo = (byte)'T',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    AddLiquidityOnlyOrderWouldRemove = (byte)'W',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    OnlyCloseTransactionsAccepted = (byte)'c',
    RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    MaxOpenOrdersCountExceeded = (byte)'o',
    ReserveReload = (byte)'r',
    RiskManagementRiskRootLevel = (byte)'s',
    WouldRemoveOnUnslide = (byte)'w',
    CrossedMarket = (byte)'x',
    OrderReceivedByCboeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
    RiskManagementEfidGroupLevel = (byte)'+',
};

/// <summary>
///  No Unspecified Unit Replay Values
/// </summary>
public enum NoUnspecifiedUnitReplay : byte {
    False = (byte)'0',
    True = (byte)'1',
    Test = (byte)'T',
};

/// <summary>
///  Open Close Values
/// </summary>
public enum OpenClose : byte {
    Open = (byte)'O',
    Close = (byte)'C',
    None = (byte)'N',
};

/// <summary>
///  Ord Type Values
/// </summary>
public enum OrdType : byte {
    Market = (byte)'1',
    Limit = (byte)'2',
    Stop = (byte)'3',
    StopLimit = (byte)'4',
};

/// <summary>
///  Order Reject Reason Values
/// </summary>
public enum OrderRejectReason : byte {
    Admin = (byte)'A',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    OrderWouldLockOrCrossNbbo = (byte)'L',
    OrderSizeExceeded = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    WaitingForFirstTrade = (byte)'Q',
    RoutingUnavailable = (byte)'R',
    FillWouldTradeThroughTheNbbo = (byte)'T',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    AddLiquidityOnlyOrderWouldRemove = (byte)'W',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    OnlyCloseTransactionsAccepted = (byte)'c',
    RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    MaxOpenOrdersCountExceeded = (byte)'o',
    ReserveReload = (byte)'r',
    RiskManagementRiskRootLevel = (byte)'s',
    WouldRemoveOnUnslide = (byte)'w',
    CrossedMarket = (byte)'x',
    OrderReceivedByCboeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
    RiskManagementEfidGroupLevel = (byte)'+',
};

/// <summary>
///  Param Group Type Values
/// </summary>
public enum ParamGroupType : byte {
    UnitSequences = 0x80,
    ReturnBitfields = 0x81,
};

/// <summary>
///  Posting Instruction Values
/// </summary>
public enum PostingInstruction : byte {
    PostOnly = (byte)'P',
    BookOnly = (byte)'B',
    BookOnlyNoSlide = (byte)'N',
    PostOnlyNoSlide = (byte)'R',
};

/// <summary>
///  Purge Reject Reason Values
/// </summary>
public enum PurgeRejectReason : byte {
    Admin = (byte)'A',
    DuplicateIdentifier = (byte)'D',
    Halted = (byte)'H',
    IncorrectDataCenter = (byte)'I',
    TooLateToCancel = (byte)'J',
    OrderRateThresholdExceeded = (byte)'K',
    OrderWouldLockOrCrossNbbo = (byte)'L',
    OrderSizeExceeded = (byte)'M',
    RanOutOfLiquidityToExecuteAgainst = (byte)'N',
    ClOrdIdDoesntMatchAKnownOrder = (byte)'O',
    CantModifyAnOrderThatIsPendingFill = (byte)'P',
    WaitingForFirstTrade = (byte)'Q',
    RoutingUnavailable = (byte)'R',
    FillWouldTradeThroughTheNbbo = (byte)'T',
    UserRequested = (byte)'U',
    WouldWash = (byte)'V',
    AddLiquidityOnlyOrderWouldRemove = (byte)'W',
    OrderExpired = (byte)'X',
    SymbolNotSupported = (byte)'Y',
    UnforeseenReason = (byte)'Z',
    OnlyCloseTransactionsAccepted = (byte)'c',
    RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
    MarketAccessRiskLimitExceeded = (byte)'m',
    MaxOpenOrdersCountExceeded = (byte)'o',
    ReserveReload = (byte)'r',
    RiskManagementRiskRootLevel = (byte)'s',
    WouldRemoveOnUnslide = (byte)'w',
    CrossedMarket = (byte)'x',
    OrderReceivedByCboeDuringReplay = (byte)'y',
    SessionEnd = (byte)'z',
    RiskManagementEfidGroupLevel = (byte)'+',
};

/// <summary>
///  Put Or Call Values
/// </summary>
public enum PutOrCall : byte {
    Put = (byte)'0',
    Call = (byte)'1',
};

/// <summary>
///  Quote Liquidity Indicator Values
/// </summary>
public enum QuoteLiquidityIndicator : byte {
    Normal = (byte)'N',
    NbboSetter = (byte)'S',
    NbboJoiner = (byte)'J',
    MarketTurner = (byte)'U',
    NoQuoteOnBook = (byte)' ',
};

/// <summary>
///  Quote Reject Reason Values
/// </summary>
public enum QuoteRejectReason : byte {
    InvalidEfid = (byte)'C',
    InvalidWashId = (byte)'D',
    InvalidSessionEligibility = (byte)'E',
    NotEnabledForQuotes = (byte)'F',
    IncorrectDataCenter = (byte)'I',
    InvalidQuoteCnt = (byte)'L',
    SymbolsNotOnSameMatchingEngine = (byte)'M',
    InvalidPostingInstruction = (byte)'P',
    InvalidQuoteUpdateId = (byte)'Q',
    RiskRootDoesNotMatchAcrossQuotes = (byte)'R',
    SymbolNotFound = (byte)'S',
    InvalidWashPreventType = (byte)'W',
    Admin = (byte)'a',
    InvalidCapacity = (byte)'C',
    CloseOnly = (byte)'d',
    RiskManagementEfidOrCustomGroupIdLevel = (byte)'f',
    InvalidWashMethod = (byte)'m',
    InvalidOpenClose = (byte)'p',
    RiskManagementRiskRootLevel = (byte)'p',
    InvalidRemove = (byte)'r',
    InvalidSide = (byte)'s',
    SymbolRangeUnreachable = (byte)'u',
    QuoteReceivedByCboeDuringReplay = (byte)'y',
};

/// <summary>
///  Quote Result Values
/// </summary>
public enum QuoteResult : byte {
    NewQuote = (byte)'A',
    ModifiedLossOfPriority = (byte)'L',
    ModifiedRetainsPriority = (byte)'R',
    NoChangeMatchesExistingQuote = (byte)'N',
    NewQuoteButMayRemoveLiquidity = (byte)'D',
    ModifiedButMayRemoveLiquidity = (byte)'d',
    UserCancelled = (byte)'U',
    AdminRejection = (byte)'a',
    RejectedCan’TPost = (byte)'P',
    RiskManagementFirmOrCustomGroupIdLevel = (byte)'f',
    RejectedSymbolNotFound = (byte)'S',
    RejectedInvalidPrice = (byte)'p',
    InvalidRemove = (byte)'r',
    RiskManagementRiskRootLevel = (byte)'s',
    RejectedOtherReason = (byte)'u',
    RiskManagementEfidGroupLevel = (byte)'+',
    RejectedClosingOnlySeries = (byte)'c',
};

/// <summary>
///  Restatement Reason Values
/// </summary>
public enum RestatementReason : byte {
    Reload = (byte)'L',
    PriceSlidingReprice = (byte)'P',
    LiquidityUpdated = (byte)'Q',
    Reroute = (byte)'R',
    ShipAndPost = (byte)'S',
    Wash = (byte)'W',
    UnsolicitedFloorAction = (byte)'f',
    PriceSlidingReprice = (byte)'K',
    Liquidity = (byte)'Q',
};

/// <summary>
///  Risk Reset Result Values
/// </summary>
public enum RiskResetResult : byte {
    Ignored = (byte)' ',
    Success = (byte)'Y',
    RejectedExceedsFirmResetLimit = (byte)'F',
    RejectedExceedsCustomGroupIdLimit = (byte)'C',
    RejectedAutomaticRiskResetsAreDisabled = (byte)'D',
    RejectedEmptyResetRiskField = (byte)'E',
    RejectedIncorrectDataCenter = (byte)'I',
    RejectedExceedsRiskRootResetLimit = (byte)'S',
    RejectedInvalidRiskRoot = (byte)'U',
    RejectedInvalidEfidOrClearingFirm = (byte)'c',
    RejectedInReplay = (byte)'y',
};

/// <summary>
///  Session Eligibility Values
/// </summary>
public enum SessionEligibility : byte {
    Rth = (byte)'R',
};

/// <summary>
///  Side Values
/// </summary>
public enum Side : byte {
    Buy = (byte)'1',
    Sell = (byte)'2',
};

/// <summary>
///  Sub Liquidity Indicator Values
/// </summary>
public enum SubLiquidityIndicator : byte {
    ExecutionFromOrderThatSetTheNbbo = (byte)'S',
    StepUpMechanism = (byte)'B',
    Carried = (byte)'C',
    DoneForDay = (byte)'D',
};

/// <summary>
///  Time In Force Values
/// </summary>
public enum TimeInForce : byte {
    Day = (byte)'0',
    Gtc = (byte)'1',
    Ato = (byte)'2',
    Ioc = (byte)'3',
    Fok = (byte)'4',
    Gtd = (byte)'6',
    Atc = (byte)'6',
};


///////////////////////////////////////////////////////////////////////
// Structs
///////////////////////////////////////////////////////////////////////

/// <summary>
///  Struct for Cancel Order Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelOrderByte1 {
    public fixed byte CancelOrderReservedBit8Exists[1];
    public fixed byte CancelOrderReservedBit7Exists[1];
    public fixed byte CancelOrderReservedBit6Exists[1];
    public fixed byte CancelOrderMassCancelIdExists[1];
    public fixed byte CancelOrderRiskRootExists[1];
    public fixed byte CancelOrderMassCancelExists[1];
    public fixed byte CancelOrderMassCancelLockoutExists[1];
    public fixed byte CancelOrderClearingFirmExists[1];
};

/// <summary>
///  Struct for Cancel Order Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelOrderByte2 {
    public fixed byte CancelOrderReservedBit8Exists[1];
    public fixed byte CancelOrderReservedBit7Exists[1];
    public fixed byte CancelOrderReservedBit6Exists[1];
    public fixed byte CancelOrderReservedBit5Exists[1];
    public fixed byte CancelOrderReservedBit4Exists[1];
    public fixed byte CancelOrderReservedBit3Exists[1];
    public fixed byte CancelOrderReservedBit2Exists[1];
    public fixed byte CancelOrderMassCancelInstExists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte1 {
    public fixed byte CancelRejectedMaxRemovePctExists[1];
    public fixed byte CancelRejectedMinQtyExists[1];
    public fixed byte CancelRejectedTimeInForceExists[1];
    public fixed byte CancelRejectedOrdTypeExists[1];
    public fixed byte CancelRejectedExecInstExists[1];
    public fixed byte CancelRejectedPriceExists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedSideExists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte10 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedCrossIdExists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte11 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte12 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte13 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte14 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte15 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedMassCancelIdExists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte16 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte17 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte2 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedCapacityExists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedSymbolExists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte3 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte4 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedCorrectedSizeExists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedOpenCloseExists[1];
    public fixed byte CancelRejectedPutOrCallExists[1];
    public fixed byte CancelRejectedStrikePriceExists[1];
    public fixed byte CancelRejectedMaturityDateExists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte5 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte6 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte7 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte8 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedReservedBit6Exists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedStopPxExists[1];
    public fixed byte CancelRejectedEchoTextExists[1];
    public fixed byte CancelRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Cancel Rejected Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CancelRejectedByte9 {
    public fixed byte CancelRejectedReservedBit8Exists[1];
    public fixed byte CancelRejectedReservedBit7Exists[1];
    public fixed byte CancelRejectedCmtaNumberExists[1];
    public fixed byte CancelRejectedReservedBit5Exists[1];
    public fixed byte CancelRejectedReservedBit4Exists[1];
    public fixed byte CancelRejectedReservedBit3Exists[1];
    public fixed byte CancelRejectedReservedBit2Exists[1];
    public fixed byte CancelRejectedMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Cross Order Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct CrossOrderRejectedMessage {
    public ulong TransactionTime;
    public fixed sbyte CrossId[20];
    public OrderRejectReason OrderRejectReason;
    public fixed sbyte Text[60];
    public fixed sbyte ReservedInternal[1];
};

/// <summary>
///  Struct for Logout Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct LogoutMessage {
    public LogoutReason LogoutReason;
    public fixed sbyte LogoutReasonText[60];
    public uint LastReceivedSequenceNumber;
    public byte NumberOfUnits;
};

/// <summary>
///  Struct for Mass Cancel Acknowledgment Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MassCancelAcknowledgmentMessage {
    public ulong TransactionTime;
    public fixed sbyte MassCancelId[20];
    public uint CancelledOrderCount;
    public fixed sbyte ReservedInternal[1];
};

/// <summary>
///  Struct for Message Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct MessageHeader {
    public ushort StartOfMessage;
    public ushort MessageLength;
    public MessageType MessageType;
    public byte MatchingUnit;
    public uint SequenceNumber;
};

/// <summary>
///  Struct for Modify Order Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderByte1 {
    public fixed byte ModifyOrderSideExists[1];
    public fixed byte ModifyOrderExecInstExists[1];
    public fixed byte ModifyOrderCancelOrigOnRejectExists[1];
    public fixed byte ModifyOrderOrdTypeExists[1];
    public fixed byte ModifyOrderPriceExists[1];
    public fixed byte ModifyOrderOrderQtyExists[1];
    public fixed byte ModifyOrderReservedBit2Exists[1];
    public fixed byte ModifyOrderClearingFirmExists[1];
};

/// <summary>
///  Struct for Modify Order Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ModifyOrderByte2 {
    public fixed byte ModifyOrderReservedBit8Exists[1];
    public fixed byte ModifyOrderReservedBit7Exists[1];
    public fixed byte ModifyOrderReservedBit6Exists[1];
    public fixed byte ModifyOrderReservedBit5Exists[1];
    public fixed byte ModifyOrderReservedBit4Exists[1];
    public fixed byte ModifyOrderReservedBit3Exists[1];
    public fixed byte ModifyOrderStopPxExists[1];
    public fixed byte ModifyOrderMaxFloorExists[1];
};

/// <summary>
///  Struct for New Order Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte1 {
    public fixed byte NewOrderMaxFloorExists[1];
    public fixed byte NewOrderMinQtyExists[1];
    public fixed byte NewOrderTimeInForceExists[1];
    public fixed byte NewOrderOrdTypeExists[1];
    public fixed byte NewOrderExecInstExists[1];
    public fixed byte NewOrderPriceExists[1];
    public fixed byte NewOrderClearingAccountExists[1];
    public fixed byte NewOrderClearingFirmExists[1];
};

/// <summary>
///  Struct for New Order Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte2 {
    public fixed byte NewOrderRoutingInstExists[1];
    public fixed byte NewOrderCapacityExists[1];
    public fixed byte NewOrderReservedBit6Exists[1];
    public fixed byte NewOrderReservedBit5Exists[1];
    public fixed byte NewOrderReservedBit4Exists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderSymbolSfxExists[1];
    public fixed byte NewOrderSymbolExists[1];
};

/// <summary>
///  Struct for New Order Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte3 {
    public fixed byte NewOrderExpireTimeExists[1];
    public fixed byte NewOrderLocateReqdExists[1];
    public fixed byte NewOrderPreventMatchExists[1];
    public fixed byte NewOrderPegDifferenceExists[1];
    public fixed byte NewOrderDiscretionAmountExists[1];
    public fixed byte NewOrderMaxRemovePctExists[1];
    public fixed byte NewOrderDisplayIndicatorExists[1];
    public fixed byte NewOrderAccountExists[1];
};

/// <summary>
///  Struct for New Order Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte4 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderCmtaNumberExists[1];
    public fixed byte NewOrderOpenCloseExists[1];
    public fixed byte NewOrderRiskResetExists[1];
    public fixed byte NewOrderPutOrCallExists[1];
    public fixed byte NewOrderStrikePriceExists[1];
    public fixed byte NewOrderMaturityDateExists[1];
};

/// <summary>
///  Struct for New Order Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte5 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderReservedBit6Exists[1];
    public fixed byte NewOrderReservedBit5Exists[1];
    public fixed byte NewOrderExtExecInstExists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderAttributedQuoteExists[1];
    public fixed byte NewOrderSessionEligibilityExists[1];
};

/// <summary>
///  Struct for New Order Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte6 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderEchoTextExists[1];
    public fixed byte NewOrderExDestinationExists[1];
    public fixed byte NewOrderRouteDeliveryMethodExists[1];
    public fixed byte NewOrderRouteStrategyExists[1];
    public fixed byte NewOrderStopPxExists[1];
    public fixed byte NewOrderDisplayRangeExists[1];
};

/// <summary>
///  Struct for New Order Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte7 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderReservedBit6Exists[1];
    public fixed byte NewOrderReservedBit5Exists[1];
    public fixed byte NewOrderReservedBit4Exists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderCustomGroupIdExists[1];
    public fixed byte NewOrderReservedBit1Exists[1];
};

/// <summary>
///  Struct for New Order Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte8 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderReservedBit6Exists[1];
    public fixed byte NewOrderReservedBit5Exists[1];
    public fixed byte NewOrderClientIdAttrExists[1];
    public fixed byte NewOrderClearingOptionalDataExists[1];
    public fixed byte NewOrderCustomGroupIdExists[1];
    public fixed byte NewOrderReservedBit1Exists[1];
};

/// <summary>
///  Struct for New Order Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct NewOrderByte9 {
    public fixed byte NewOrderReservedBit8Exists[1];
    public fixed byte NewOrderReservedBit7Exists[1];
    public fixed byte NewOrderReservedBit6Exists[1];
    public fixed byte NewOrderReservedBit5Exists[1];
    public fixed byte NewOrderReservedBit4Exists[1];
    public fixed byte NewOrderReservedBit3Exists[1];
    public fixed byte NewOrderReservedBit2Exists[1];
    public fixed byte NewOrderReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte1 {
    public fixed byte OrderAcknowledgmentMaxRemovePctExists[1];
    public fixed byte OrderAcknowledgmentMinQtyExists[1];
    public fixed byte OrderAcknowledgmentTimeInForceExists[1];
    public fixed byte OrderAcknowledgmentOrdTypeExists[1];
    public fixed byte OrderAcknowledgmentExecInstExists[1];
    public fixed byte OrderAcknowledgmentPriceExists[1];
    public fixed byte OrderAcknowledgmentPegDifferenceExists[1];
    public fixed byte OrderAcknowledgmentSideExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte10 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentCrossIdExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte11 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte12 {
    public fixed byte OrderAcknowledgmentClearingOptionalDataExists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte13 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte14 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte15 {
    public fixed byte OrderAcknowledgmentClientIdAttrExists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte16 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentSessionEligibilityExists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte17 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte2 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentCapacityExists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentSymbolExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte3 {
    public fixed byte OrderAcknowledgmentPreventMatchExists[1];
    public fixed byte OrderAcknowledgmentOrderQtyExists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentMaxFloorExists[1];
    public fixed byte OrderAcknowledgmentDisplayIndicatorExists[1];
    public fixed byte OrderAcknowledgmentClearingAccountExists[1];
    public fixed byte OrderAcknowledgmentClearingFirmExists[1];
    public fixed byte OrderAcknowledgmentAccountExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte4 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentCorrectedSizeExists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentOpenCloseExists[1];
    public fixed byte OrderAcknowledgmentPutOrCallExists[1];
    public fixed byte OrderAcknowledgmentStrikePriceExists[1];
    public fixed byte OrderAcknowledgmentMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte5 {
    public fixed byte OrderAcknowledgmentExpireTimeExists[1];
    public fixed byte OrderAcknowledgmentBaseLiquidityIndicatorExists[1];
    public fixed byte OrderAcknowledgmentWorkingPriceExists[1];
    public fixed byte OrderAcknowledgmentDisplayPriceExists[1];
    public fixed byte OrderAcknowledgmentLastPxExists[1];
    public fixed byte OrderAcknowledgmentLastSharesExists[1];
    public fixed byte OrderAcknowledgmentLeavesQtyExists[1];
    public fixed byte OrderAcknowledgmentOrigClOrdIdExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte6 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentAttributedQuoteExists[1];
    public fixed byte OrderAcknowledgmentContraCapacityExists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentSecondaryOrderIdExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte7 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentSubLiquidityIndicatorExists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte8 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentExDestinationExists[1];
    public fixed byte OrderAcknowledgmentRouteDeliveryMethodExists[1];
    public fixed byte OrderAcknowledgmentRouteStrategyExists[1];
    public fixed byte OrderAcknowledgmentRoutingInstExists[1];
    public fixed byte OrderAcknowledgmentStopPxExists[1];
    public fixed byte OrderAcknowledgmentEchoTextExists[1];
    public fixed byte OrderAcknowledgmentReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Acknowledgment Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderAcknowledgmentByte9 {
    public fixed byte OrderAcknowledgmentReservedBit8Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit7Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit6Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit5Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit4Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit3Exists[1];
    public fixed byte OrderAcknowledgmentReservedBit2Exists[1];
    public fixed byte OrderAcknowledgmentMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte1 {
    public fixed byte OrderCancelledMaxRemovePctExists[1];
    public fixed byte OrderCancelledMinQtyExists[1];
    public fixed byte OrderCancelledTimeInForceExists[1];
    public fixed byte OrderCancelledOrdTypeExists[1];
    public fixed byte OrderCancelledExecInstExists[1];
    public fixed byte OrderCancelledPriceExists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledSideExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte10 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledCrossIdExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte11 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte12 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte13 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte14 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte15 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte16 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte17 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte2 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledCapacityExists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledSymbolExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte3 {
    public fixed byte OrderCancelledPreventMatchExists[1];
    public fixed byte OrderCancelledOrderQtyExists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledMaxFloorExists[1];
    public fixed byte OrderCancelledDisplayIndicatorExists[1];
    public fixed byte OrderCancelledClearingAccountExists[1];
    public fixed byte OrderCancelledClearingFirmExists[1];
    public fixed byte OrderCancelledAccountExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte4 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledCorrectedSizeExists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledOpenCloseExists[1];
    public fixed byte OrderCancelledPutOrCallExists[1];
    public fixed byte OrderCancelledStrikePriceExists[1];
    public fixed byte OrderCancelledMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte5 {
    public fixed byte OrderCancelledExpireTimeExists[1];
    public fixed byte OrderCancelledBaseLiquidityIndicatorExists[1];
    public fixed byte OrderCancelledWorkingPriceExists[1];
    public fixed byte OrderCancelledDisplayPriceExists[1];
    public fixed byte OrderCancelledLastPxExists[1];
    public fixed byte OrderCancelledLastSharesExists[1];
    public fixed byte OrderCancelledLeavesQtyExists[1];
    public fixed byte OrderCancelledOrigClOrdIdExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte6 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledAttributedQuoteExists[1];
    public fixed byte OrderCancelledContraCapacityExists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledSecondaryOrderIdExists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte7 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledReservedBit6Exists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte8 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledExDestinationExists[1];
    public fixed byte OrderCancelledRouteDeliveryMethodExists[1];
    public fixed byte OrderCancelledRouteStrategyExists[1];
    public fixed byte OrderCancelledRoutingInstExists[1];
    public fixed byte OrderCancelledStopPxExists[1];
    public fixed byte OrderCancelledEchoTextExists[1];
    public fixed byte OrderCancelledReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Cancelled Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderCancelledByte9 {
    public fixed byte OrderCancelledReservedBit8Exists[1];
    public fixed byte OrderCancelledReservedBit7Exists[1];
    public fixed byte OrderCancelledCmtaNumberExists[1];
    public fixed byte OrderCancelledReservedBit5Exists[1];
    public fixed byte OrderCancelledReservedBit4Exists[1];
    public fixed byte OrderCancelledReservedBit3Exists[1];
    public fixed byte OrderCancelledReservedBit2Exists[1];
    public fixed byte OrderCancelledMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte1 {
    public fixed byte OrderExecutionMaxRemovePctExists[1];
    public fixed byte OrderExecutionMinQtyExists[1];
    public fixed byte OrderExecutionTimeInForceExists[1];
    public fixed byte OrderExecutionOrdTypeExists[1];
    public fixed byte OrderExecutionExecInstExists[1];
    public fixed byte OrderExecutionPriceExists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionSideExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte10 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionCrossIdExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte11 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte12 {
    public fixed byte OrderExecutionClearingOptionalDataExists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte13 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionDayAvgPxExists[1];
    public fixed byte OrderExecutionAvgPxExists[1];
    public fixed byte OrderExecutionDayCumQtyExists[1];
    public fixed byte OrderExecutionDayOrderQtyExists[1];
    public fixed byte OrderExecutionCumQtyExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte14 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte15 {
    public fixed byte OrderExecutionClientIdAttrExists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte16 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte17 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte2 {
    public fixed byte OrderExecutionContraTraderExists[1];
    public fixed byte OrderExecutionCapacityExists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionSymbolExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte3 {
    public fixed byte OrderExecutionPreventMatchExists[1];
    public fixed byte OrderExecutionOrderQtyExists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionMaxFloorExists[1];
    public fixed byte OrderExecutionDisplayIndicatorExists[1];
    public fixed byte OrderExecutionClearingAccountExists[1];
    public fixed byte OrderExecutionClearingFirmExists[1];
    public fixed byte OrderExecutionAccountExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte4 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionCorrectedSizeExists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionOpenCloseExists[1];
    public fixed byte OrderExecutionPutOrCallExists[1];
    public fixed byte OrderExecutionStrikePriceExists[1];
    public fixed byte OrderExecutionMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte5 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte6 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionAttributedQuoteExists[1];
    public fixed byte OrderExecutionContraCapacityExists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte7 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionReservedBit6Exists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Execution Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte8 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionExDestinationExists[1];
    public fixed byte OrderExecutionRouteDeliveryMethodExists[1];
    public fixed byte OrderExecutionRouteStrategyExists[1];
    public fixed byte OrderExecutionRoutingInstExists[1];
    public fixed byte OrderExecutionStopPxExists[1];
    public fixed byte OrderExecutionEchoTextExists[1];
    public fixed byte OrderExecutionFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Execution Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderExecutionByte9 {
    public fixed byte OrderExecutionReservedBit8Exists[1];
    public fixed byte OrderExecutionReservedBit7Exists[1];
    public fixed byte OrderExecutionCmtaNumberExists[1];
    public fixed byte OrderExecutionReservedBit5Exists[1];
    public fixed byte OrderExecutionReservedBit4Exists[1];
    public fixed byte OrderExecutionReservedBit3Exists[1];
    public fixed byte OrderExecutionReservedBit2Exists[1];
    public fixed byte OrderExecutionMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte1 {
    public fixed byte OrderModifiedMaxRemovePctExists[1];
    public fixed byte OrderModifiedMinQtyExists[1];
    public fixed byte OrderModifiedTimeInForceExists[1];
    public fixed byte OrderModifiedOrdTypeExists[1];
    public fixed byte OrderModifiedExecInstExists[1];
    public fixed byte OrderModifiedPriceExists[1];
    public fixed byte OrderModifiedPegDifferenceExists[1];
    public fixed byte OrderModifiedSideExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte10 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedCrossIdExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte11 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte12 {
    public fixed byte OrderModifiedClearingOptionalDataExists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte13 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte14 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte15 {
    public fixed byte OrderModifiedClientIdAttrExists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte16 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedSessionEligibilityExists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte17 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte2 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedCapacityExists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedSymbolExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte3 {
    public fixed byte OrderModifiedPreventMatchExists[1];
    public fixed byte OrderModifiedOrderQtyExists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedMaxFloorExists[1];
    public fixed byte OrderModifiedDisplayIndicatorExists[1];
    public fixed byte OrderModifiedClearingAccountExists[1];
    public fixed byte OrderModifiedClearingFirmExists[1];
    public fixed byte OrderModifiedAccountExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte4 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedCorrectedSizeExists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedOpenCloseExists[1];
    public fixed byte OrderModifiedPutOrCallExists[1];
    public fixed byte OrderModifiedStrikePriceExists[1];
    public fixed byte OrderModifiedMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte5 {
    public fixed byte OrderModifiedExpireTimeExists[1];
    public fixed byte OrderModifiedBaseLiquidityIndicatorExists[1];
    public fixed byte OrderModifiedWorkingPriceExists[1];
    public fixed byte OrderModifiedDisplayPriceExists[1];
    public fixed byte OrderModifiedLastPxExists[1];
    public fixed byte OrderModifiedLastSharesExists[1];
    public fixed byte OrderModifiedLeavesQtyExists[1];
    public fixed byte OrderModifiedOrigClOrdIdExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte6 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedAttributedQuoteExists[1];
    public fixed byte OrderModifiedContraCapacityExists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedSecondaryOrderIdExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte7 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedSubLiquidityIndicatorExists[1];
};

/// <summary>
///  Struct for Order Modified Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte8 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedExDestinationExists[1];
    public fixed byte OrderModifiedRouteDeliveryMethodExists[1];
    public fixed byte OrderModifiedRouteStrategyExists[1];
    public fixed byte OrderModifiedRoutingInstExists[1];
    public fixed byte OrderModifiedStopPxExists[1];
    public fixed byte OrderModifiedEchoTextExists[1];
    public fixed byte OrderModifiedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Modified Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderModifiedByte9 {
    public fixed byte OrderModifiedReservedBit8Exists[1];
    public fixed byte OrderModifiedReservedBit7Exists[1];
    public fixed byte OrderModifiedReservedBit6Exists[1];
    public fixed byte OrderModifiedReservedBit5Exists[1];
    public fixed byte OrderModifiedReservedBit4Exists[1];
    public fixed byte OrderModifiedReservedBit3Exists[1];
    public fixed byte OrderModifiedReservedBit2Exists[1];
    public fixed byte OrderModifiedMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte1 {
    public fixed byte OrderRejectedMaxRemovePctExists[1];
    public fixed byte OrderRejectedMinQtyExists[1];
    public fixed byte OrderRejectedTimeInForceExists[1];
    public fixed byte OrderRejectedOrdTypeExists[1];
    public fixed byte OrderRejectedExecInstExists[1];
    public fixed byte OrderRejectedPriceExists[1];
    public fixed byte OrderRejectedPegDifferenceExists[1];
    public fixed byte OrderRejectedSideExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte10 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedCrossIdExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte11 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte12 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte13 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte14 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte15 {
    public fixed byte OrderRejectedClientIdAttrExists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte16 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedSessionEligibilityExists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte17 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte2 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedCapacityExists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedSymbolExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte3 {
    public fixed byte OrderRejectedPreventMatchExists[1];
    public fixed byte OrderRejectedOrderQtyExists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedMaxFloorExists[1];
    public fixed byte OrderRejectedDisplayIndicatorExists[1];
    public fixed byte OrderRejectedClearingAccountExists[1];
    public fixed byte OrderRejectedClearingFirmExists[1];
    public fixed byte OrderRejectedAccountExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte4 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedCorrectedSizeExists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedOpenCloseExists[1];
    public fixed byte OrderRejectedPutOrCallExists[1];
    public fixed byte OrderRejectedStrikePriceExists[1];
    public fixed byte OrderRejectedMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte5 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte6 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedAttributedQuoteExists[1];
    public fixed byte OrderRejectedContraCapacityExists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedSecondaryOrderIdExists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte7 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedReservedBit6Exists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte8 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedExDestinationExists[1];
    public fixed byte OrderRejectedRouteDeliveryMethodExists[1];
    public fixed byte OrderRejectedRouteStrategyExists[1];
    public fixed byte OrderRejectedRoutingInstExists[1];
    public fixed byte OrderRejectedStopPxExists[1];
    public fixed byte OrderRejectedEchoTextExists[1];
    public fixed byte OrderRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Rejected Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRejectedByte9 {
    public fixed byte OrderRejectedReservedBit8Exists[1];
    public fixed byte OrderRejectedReservedBit7Exists[1];
    public fixed byte OrderRejectedCmtaNumberExists[1];
    public fixed byte OrderRejectedReservedBit5Exists[1];
    public fixed byte OrderRejectedReservedBit4Exists[1];
    public fixed byte OrderRejectedReservedBit3Exists[1];
    public fixed byte OrderRejectedReservedBit2Exists[1];
    public fixed byte OrderRejectedMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte1 {
    public fixed byte OrderRestatedMaxRemovePctExists[1];
    public fixed byte OrderRestatedMinQtyExists[1];
    public fixed byte OrderRestatedTimeInForceExists[1];
    public fixed byte OrderRestatedOrdTypeExists[1];
    public fixed byte OrderRestatedExecInstExists[1];
    public fixed byte OrderRestatedPriceExists[1];
    public fixed byte OrderRestatedPegDifferenceExists[1];
    public fixed byte OrderRestatedSideExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte10 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedCrossIdExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte11 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte12 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte13 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte14 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte15 {
    public fixed byte OrderRestatedClientIdAttrExists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte16 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte17 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte2 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedCapacityExists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedSymbolExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte3 {
    public fixed byte OrderRestatedPreventMatchExists[1];
    public fixed byte OrderRestatedOrderQtyExists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedMaxFloorExists[1];
    public fixed byte OrderRestatedDisplayIndicatorExists[1];
    public fixed byte OrderRestatedClearingAccountExists[1];
    public fixed byte OrderRestatedClearingFirmExists[1];
    public fixed byte OrderRestatedAccountExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte4 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedCorrectedSizeExists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedOpenCloseExists[1];
    public fixed byte OrderRestatedPutOrCallExists[1];
    public fixed byte OrderRestatedStrikePriceExists[1];
    public fixed byte OrderRestatedMaturityDateExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte5 {
    public fixed byte OrderRestatedExpireTimeExists[1];
    public fixed byte OrderRestatedBaseLiquidityIndicatorExists[1];
    public fixed byte OrderRestatedWorkingPriceExists[1];
    public fixed byte OrderRestatedDisplayPriceExists[1];
    public fixed byte OrderRestatedLastPxExists[1];
    public fixed byte OrderRestatedLastSharesExists[1];
    public fixed byte OrderRestatedLeavesQtyExists[1];
    public fixed byte OrderRestatedOrigClOrdIdExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte6 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedAttributedQuoteExists[1];
    public fixed byte OrderRestatedContraCapacityExists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedSecondaryOrderIdExists[1];
};

/// <summary>
///  Struct for Order Restated Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte7 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedReservedBit6Exists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte8 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedExDestinationExists[1];
    public fixed byte OrderRestatedRouteDeliveryMethodExists[1];
    public fixed byte OrderRestatedRouteStrategyExists[1];
    public fixed byte OrderRestatedRoutingInstExists[1];
    public fixed byte OrderRestatedStopPxExists[1];
    public fixed byte OrderRestatedEchoTextExists[1];
    public fixed byte OrderRestatedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Order Restated Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct OrderRestatedByte9 {
    public fixed byte OrderRestatedReservedBit8Exists[1];
    public fixed byte OrderRestatedReservedBit7Exists[1];
    public fixed byte OrderRestatedCmtaNumberExists[1];
    public fixed byte OrderRestatedReservedBit5Exists[1];
    public fixed byte OrderRestatedReservedBit4Exists[1];
    public fixed byte OrderRestatedReservedBit3Exists[1];
    public fixed byte OrderRestatedReservedBit2Exists[1];
    public fixed byte OrderRestatedMarketFeeCodeExists[1];
};

/// <summary>
///  Struct for Param Header
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ParamHeader {
    public ushort ParamGroupLength;
    public ParamGroupType ParamGroupType;
};

/// <summary>
///  Struct for Purge Rejected Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte1 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte10 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte11 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte12 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte13 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte14 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte15 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedMassCancelIdExists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte16 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte17 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte2 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte3 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte4 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte5 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte6 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte7 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte8 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Purge Rejected Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct PurgeRejectedByte9 {
    public fixed byte PurgeRejectedReservedBit8Exists[1];
    public fixed byte PurgeRejectedReservedBit7Exists[1];
    public fixed byte PurgeRejectedReservedBit6Exists[1];
    public fixed byte PurgeRejectedReservedBit5Exists[1];
    public fixed byte PurgeRejectedReservedBit4Exists[1];
    public fixed byte PurgeRejectedReservedBit3Exists[1];
    public fixed byte PurgeRejectedReservedBit2Exists[1];
    public fixed byte PurgeRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for Quote Cancelled Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteCancelledMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong OrderId;
    public fixed sbyte Symbol[6];
    public Side Side;
    public CancelReason CancelReason;
};

/// <summary>
///  Struct for Quote Execution Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteExecutionMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong OrderId;
    public ulong ExecId;
    public fixed sbyte Symbol[6];
    public fixed sbyte ClearingFirm[4];
    public uint LastShares;
    public long LastPx;
    public uint LeavesQty;
    public fixed sbyte ContraTrader[4];
    public fixed sbyte ContraCapacity[1];
    public Side Side;
    public BaseLiquidityIndicator BaseLiquidityIndicator;
    public SubLiquidityIndicator SubLiquidityIndicator;
    public fixed sbyte FeeCode[2];
    public fixed sbyte MarketingFeeCode[2];
};

/// <summary>
///  Struct for Quote Restated Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteRestatedMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public ulong OrderId;
    public uint LeavesQty;
    public ulong WorkingPrice;
    public fixed sbyte Symbol[6];
    public Side Side;
    public fixed sbyte QuoteRestatementReason[1];
};

/// <summary>
///  Struct for Quote Result Group
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteResultGroup {
    public ulong OrderId;
    public QuoteResult QuoteResult;
    public QuoteLiquidityIndicator QuoteLiquidityIndicator;
    public fixed byte Reserved6;
};

/// <summary>
///  Struct for Quote Update
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdate {
    public fixed sbyte Symbol[6];
    public Side Side;
    public OpenClose OpenClose;
    public long Price;
    public uint OrderQty;
    public fixed byte Reserved12[12];
};

/// <summary>
///  Struct for Quote Update Acknowledgment Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateAcknowledgmentMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public QuoteRejectReason QuoteRejectReason;
    public fixed byte Reserved17[17];
    public byte NumberOfQuoteResults;
};

/// <summary>
///  Struct for Quote Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateMessage {
    public fixed sbyte QuoteUpdateId[16];
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte ClearingAccount[4];
    public uint CmtaNumber;
    public fixed sbyte Account[16];
    public ushort CustomGroupId;
    public Capacity Capacity;
    public fixed byte Reserved15[15];
    public ulong SendTime;
    public PostingInstruction PostingInstruction;
    public SessionEligibility SessionEligibility;
    public byte NumberOfQuoteUpdates;
};

/// <summary>
///  Struct for Quote Update Rejected Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct QuoteUpdateRejectedMessage {
    public ulong TransactionTime;
    public fixed sbyte QuoteUpdateId[16];
    public QuoteRejectReason QuoteRejectReason;
    public fixed byte Reserved17[17];
};

/// <summary>
///  Struct for Reset Risk Acknowledgment Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ResetRiskAcknowledgmentMessage {
    public fixed sbyte RiskStatusId[16];
    public RiskResetResult RiskResetResult;
};

/// <summary>
///  Struct for Risk Reset Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct RiskResetMessage {
    public fixed sbyte RiskStatusId[16];
    public fixed sbyte RiskReset[8];
    public uint Reserved4;
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte RiskRoot[6];
    public ushort CustomGroupId;
};

/// <summary>
///  Struct for Short Quote Update
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteUpdate {
    public fixed sbyte Symbol[6];
    public Side Side;
    public OpenClose OpenClose;
    public long Price;
    public uint OrderQty;
    public ushort Reserved2;
};

/// <summary>
///  Struct for Short Quote Update Message
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct ShortQuoteUpdateMessage {
    public fixed sbyte QuoteUpdateId[16];
    public fixed sbyte ClearingFirm[4];
    public fixed sbyte ClearingAccount[4];
    public ushort CustomGroupId;
    public Capacity Capacity;
    public fixed byte Reserved3;
    public ulong SendTime;
    public PostingInstruction PostingInstruction;
    public SessionEligibility SessionEligibility;
    public byte NumberOfShortQuoteUpdates;
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte1 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte10 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectCrossIdExists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte11 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte12 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte13 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte14 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte15 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte16 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte17 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte2 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectCapacityExists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectSymbolExists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte3 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte4 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectCorrectedSizeExists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectOpenCloseExists[1];
    public fixed byte TradeCancelOrCorrectPutOrCallExists[1];
    public fixed byte TradeCancelOrCorrectStrikePriceExists[1];
    public fixed byte TradeCancelOrCorrectMaturityDateExists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte5 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte6 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte7 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectSubLiquidityIndicatorExists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte8 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit6Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Trade Cancel Or Correct Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct TradeCancelOrCorrectByte9 {
    public fixed byte TradeCancelOrCorrectReservedBit8Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit7Exists[1];
    public fixed byte TradeCancelOrCorrectCmtaNumberExists[1];
    public fixed byte TradeCancelOrCorrectReservedBit5Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit4Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit3Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit2Exists[1];
    public fixed byte TradeCancelOrCorrectReservedBit1Exists[1];
};

/// <summary>
///  Struct for Unit Sequence
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnitSequence {
    public byte UnitNumber;
    public uint SequenceNumber;
};

/// <summary>
///  Struct for Unit Sequences
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UnitSequences {
    public NoUnspecifiedUnitReplay NoUnspecifiedUnitReplay;
    public byte NumberOfUnits;
};

/// <summary>
///  Struct for User Modify Rejected Byte 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte1 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 10
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte10 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedCrossIdExists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 11
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte11 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 12
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte12 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 13
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte13 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 14
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte14 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 15
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte15 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 16
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte16 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 17
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte17 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 2
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte2 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 3
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte3 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 4
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte4 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 5
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte5 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 6
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte6 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 7
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte7 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 8
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte8 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

/// <summary>
///  Struct for User Modify Rejected Byte 9
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe struct UserModifyRejectedByte9 {
    public fixed byte UserModifyRejectedReservedBit8Exists[1];
    public fixed byte UserModifyRejectedReservedBit7Exists[1];
    public fixed byte UserModifyRejectedReservedBit6Exists[1];
    public fixed byte UserModifyRejectedReservedBit5Exists[1];
    public fixed byte UserModifyRejectedReservedBit4Exists[1];
    public fixed byte UserModifyRejectedReservedBit3Exists[1];
    public fixed byte UserModifyRejectedReservedBit2Exists[1];
    public fixed byte UserModifyRejectedReservedBit1Exists[1];
};

