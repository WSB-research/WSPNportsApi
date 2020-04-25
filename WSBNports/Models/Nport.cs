namespace WSBNports
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using WSBNports.Models;

    public partial class Nport : Entity
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public NportClass Empty { get; set; }

        [JsonProperty("headerData", NullValueHandling = NullValueHandling.Ignore)]
        public HeaderData HeaderData { get; set; }

        [JsonProperty("formData", NullValueHandling = NullValueHandling.Ignore)]
        public FormData FormData { get; set; }

        [JsonProperty("documents", NullValueHandling = NullValueHandling.Ignore)]
        public string Documents { get; set; }

        [JsonProperty("documentNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentNumber { get; set; }

        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Link { get; set; }

        [JsonProperty("filerCik", NullValueHandling = NullValueHandling.Ignore)]
        public string FilerCik { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("_rid", NullValueHandling = NullValueHandling.Ignore)]
        public string Rid { get; set; }

        [JsonProperty("_self", NullValueHandling = NullValueHandling.Ignore)]
        public string Self { get; set; }

        [JsonProperty("_etag", NullValueHandling = NullValueHandling.Ignore)]
        public string Etag { get; set; }

        [JsonProperty("_attachments", NullValueHandling = NullValueHandling.Ignore)]
        public string Attachments { get; set; }

        [JsonProperty("_ts", NullValueHandling = NullValueHandling.Ignore)]
        public long? Ts { get; set; }
    }

    public partial class NportClass
    {
        [JsonProperty("xmlns", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Xmlns { get; set; }

        [JsonProperty("xmlns:com", NullValueHandling = NullValueHandling.Ignore)]
        public Uri XmlnsCom { get; set; }

        [JsonProperty("xmlns:ncom", NullValueHandling = NullValueHandling.Ignore)]
        public Uri XmlnsNcom { get; set; }

        [JsonProperty("xmlns:xsi", NullValueHandling = NullValueHandling.Ignore)]
        public Uri XmlnsXsi { get; set; }

        [JsonProperty("xsi:schemaLocation", NullValueHandling = NullValueHandling.Ignore)]
        public Uri XsiSchemaLocation { get; set; }
    }

    public partial class FormData
    {
        [JsonProperty("genInfo", NullValueHandling = NullValueHandling.Ignore)]
        public GenInfo GenInfo { get; set; }

        [JsonProperty("fundInfo", NullValueHandling = NullValueHandling.Ignore)]
        public FundInfo FundInfo { get; set; }

        [JsonProperty("invstOrSecs", NullValueHandling = NullValueHandling.Ignore)]
        public InvstOrSecs InvstOrSecs { get; set; }

        [JsonProperty("explntrNotes", NullValueHandling = NullValueHandling.Ignore)]
        public ExplntrNotes ExplntrNotes { get; set; }

        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public Signature Signature { get; set; }
    }

    public partial class ExplntrNotes
    {
        [JsonProperty("explntrNote", NullValueHandling = NullValueHandling.Ignore)]
        public object ExplntrNote { get; set; }
    }

    public partial class ExplntrNoteElement
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public ExplntrNote Empty { get; set; }
    }

    public partial class ExplntrNote
    {
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty("noteItem", NullValueHandling = NullValueHandling.Ignore)]
        public string NoteItem { get; set; }
    }

    public partial class FundInfo
    {
        [JsonProperty("totAssets", NullValueHandling = NullValueHandling.Ignore)]
        public string TotAssets { get; set; }

        [JsonProperty("totLiabs", NullValueHandling = NullValueHandling.Ignore)]
        public string TotLiabs { get; set; }

        [JsonProperty("netAssets", NullValueHandling = NullValueHandling.Ignore)]
        public string NetAssets { get; set; }

        [JsonProperty("assetsAttrMiscSec", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetsAttrMiscSec { get; set; }

        [JsonProperty("assetsInvested", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetsInvested { get; set; }

        [JsonProperty("amtPayOneYrBanksBorr", NullValueHandling = NullValueHandling.Ignore)]
        public string AmtPayOneYrBanksBorr { get; set; }

        [JsonProperty("amtPayOneYrCtrldComp", NullValueHandling = NullValueHandling.Ignore)]
        public string AmtPayOneYrCtrldComp { get; set; }

        [JsonProperty("amtPayOneYrOthAffil", NullValueHandling = NullValueHandling.Ignore)]
        public string AmtPayOneYrOthAffil { get; set; }

        [JsonProperty("amtPayOneYrOther", NullValueHandling = NullValueHandling.Ignore)]
        public string AmtPayOneYrOther { get; set; }

        [JsonProperty("amtPayAftOneYrBanksBorr", NullValueHandling = NullValueHandling.Ignore)]
        public string AmtPayAftOneYrBanksBorr { get; set; }

        [JsonProperty("amtPayAftOneYrCtrldComp", NullValueHandling = NullValueHandling.Ignore)]
        public string AmtPayAftOneYrCtrldComp { get; set; }

        [JsonProperty("amtPayAftOneYrOthAffil", NullValueHandling = NullValueHandling.Ignore)]
        public string AmtPayAftOneYrOthAffil { get; set; }

        [JsonProperty("amtPayAftOneYrOther", NullValueHandling = NullValueHandling.Ignore)]
        public string AmtPayAftOneYrOther { get; set; }

        [JsonProperty("delayDeliv", NullValueHandling = NullValueHandling.Ignore)]
        public string DelayDeliv { get; set; }

        [JsonProperty("standByCommit", NullValueHandling = NullValueHandling.Ignore)]
        public string StandByCommit { get; set; }

        [JsonProperty("liquidPref", NullValueHandling = NullValueHandling.Ignore)]
        public string LiquidPref { get; set; }

        [JsonProperty("cshNotRptdInCorD", NullValueHandling = NullValueHandling.Ignore)]
        public string CshNotRptdInCorD { get; set; }

        [JsonProperty("curMetrics", NullValueHandling = NullValueHandling.Ignore)]
        public CurMetrics CurMetrics { get; set; }

        [JsonProperty("creditSprdRiskInvstGrade", NullValueHandling = NullValueHandling.Ignore)]
        public CreditSprdRiskInvstGradeClass CreditSprdRiskInvstGrade { get; set; }

        [JsonProperty("creditSprdRiskNonInvstGrade", NullValueHandling = NullValueHandling.Ignore)]
        public CreditSprdRiskInvstGradeClass CreditSprdRiskNonInvstGrade { get; set; }

        [JsonProperty("isNonCashCollateral", NullValueHandling = NullValueHandling.Ignore)]
        public string IsNonCashCollateral { get; set; }

        [JsonProperty("returnInfo", NullValueHandling = NullValueHandling.Ignore)]
        public ReturnInfo ReturnInfo { get; set; }

        [JsonProperty("mon1Flow", NullValueHandling = NullValueHandling.Ignore)]
        public MonFlow Mon1Flow { get; set; }

        [JsonProperty("mon2Flow", NullValueHandling = NullValueHandling.Ignore)]
        public MonFlow Mon2Flow { get; set; }

        [JsonProperty("mon3Flow", NullValueHandling = NullValueHandling.Ignore)]
        public MonFlow Mon3Flow { get; set; }
    }

    public partial class CreditSprdRiskInvstGradeClass
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public CreditSprdRiskInvstGrade Empty { get; set; }
    }

    public partial class CreditSprdRiskInvstGrade
    {
        [JsonProperty("period10Yr", NullValueHandling = NullValueHandling.Ignore)]
        public string Period10Yr { get; set; }

        [JsonProperty("period1Yr", NullValueHandling = NullValueHandling.Ignore)]
        public string Period1Yr { get; set; }

        [JsonProperty("period30Yr", NullValueHandling = NullValueHandling.Ignore)]
        public string Period30Yr { get; set; }

        [JsonProperty("period3Mon", NullValueHandling = NullValueHandling.Ignore)]
        public string Period3Mon { get; set; }

        [JsonProperty("period5Yr", NullValueHandling = NullValueHandling.Ignore)]
        public string Period5Yr { get; set; }
    }

    public partial class CurMetrics
    {
        [JsonProperty("curMetric", NullValueHandling = NullValueHandling.Ignore)]
        public object CurMetric { get; set; }
    }

    public partial class CurMetric
    {
        [JsonProperty("curCd", NullValueHandling = NullValueHandling.Ignore)]
        public string CurCd { get; set; }

        [JsonProperty("intrstRtRiskdv01", NullValueHandling = NullValueHandling.Ignore)]
        public CreditSprdRiskInvstGradeClass IntrstRtRiskdv01 { get; set; }

        [JsonProperty("intrstRtRiskdv100", NullValueHandling = NullValueHandling.Ignore)]
        public CreditSprdRiskInvstGradeClass IntrstRtRiskdv100 { get; set; }
    }

    public partial class MonFlow
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public Mon1Flow Empty { get; set; }
    }

    public partial class Mon1Flow
    {
        [JsonProperty("redemption", NullValueHandling = NullValueHandling.Ignore)]
        public string Redemption { get; set; }

        [JsonProperty("reinvestment", NullValueHandling = NullValueHandling.Ignore)]
        public string Reinvestment { get; set; }

        [JsonProperty("sales", NullValueHandling = NullValueHandling.Ignore)]
        public string Sales { get; set; }
    }

    public partial class ReturnInfo
    {
        [JsonProperty("monthlyTotReturns", NullValueHandling = NullValueHandling.Ignore)]
        public MonthlyTotReturns MonthlyTotReturns { get; set; }

        [JsonProperty("monthlyReturnCats", NullValueHandling = NullValueHandling.Ignore)]
        public MonthlyReturnCats MonthlyReturnCats { get; set; }

        [JsonProperty("othMon1", NullValueHandling = NullValueHandling.Ignore)]
        public OthMon1Class OthMon1 { get; set; }

        [JsonProperty("othMon2", NullValueHandling = NullValueHandling.Ignore)]
        public OthMon1Class OthMon2 { get; set; }

        [JsonProperty("othMon3", NullValueHandling = NullValueHandling.Ignore)]
        public OthMon1Class OthMon3 { get; set; }
    }

    public partial class MonthlyReturnCats
    {
        [JsonProperty("creditContracts", NullValueHandling = NullValueHandling.Ignore)]
        public Contracts CreditContracts { get; set; }

        [JsonProperty("equityContracts", NullValueHandling = NullValueHandling.Ignore)]
        public Contracts EquityContracts { get; set; }

        [JsonProperty("foreignExchgContracts", NullValueHandling = NullValueHandling.Ignore)]
        public Contracts ForeignExchgContracts { get; set; }

        [JsonProperty("interestRtContracts", NullValueHandling = NullValueHandling.Ignore)]
        public Contracts InterestRtContracts { get; set; }
    }

    public partial class Contracts
    {
        [JsonProperty("mon1", NullValueHandling = NullValueHandling.Ignore)]
        public OthMon1Class Mon1 { get; set; }

        [JsonProperty("mon2", NullValueHandling = NullValueHandling.Ignore)]
        public OthMon1Class Mon2 { get; set; }

        [JsonProperty("mon3", NullValueHandling = NullValueHandling.Ignore)]
        public OthMon1Class Mon3 { get; set; }

        [JsonProperty("swaptionCategory", NullValueHandling = NullValueHandling.Ignore)]
        public Category SwaptionCategory { get; set; }

        [JsonProperty("swapCategory", NullValueHandling = NullValueHandling.Ignore)]
        public Category SwapCategory { get; set; }

        [JsonProperty("forwardCategory", NullValueHandling = NullValueHandling.Ignore)]
        public Category ForwardCategory { get; set; }

        [JsonProperty("futureCategory", NullValueHandling = NullValueHandling.Ignore)]
        public Category FutureCategory { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("instrMon1", NullValueHandling = NullValueHandling.Ignore)]
        public OthMon1Class InstrMon1 { get; set; }

        [JsonProperty("instrMon2", NullValueHandling = NullValueHandling.Ignore)]
        public OthMon1Class InstrMon2 { get; set; }

        [JsonProperty("instrMon3", NullValueHandling = NullValueHandling.Ignore)]
        public OthMon1Class InstrMon3 { get; set; }
    }

    public partial class OthMon1Class
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public OthMon1 Empty { get; set; }
    }

    public partial class OthMon1
    {
        [JsonProperty("netRealizedGain", NullValueHandling = NullValueHandling.Ignore)]
        public string NetRealizedGain { get; set; }

        [JsonProperty("netUnrealizedAppr", NullValueHandling = NullValueHandling.Ignore)]
        public string NetUnrealizedAppr { get; set; }
    }

    public partial class MonthlyTotReturns
    {
        [JsonProperty("monthlyTotReturn", NullValueHandling = NullValueHandling.Ignore)]
        public object MonthlyTotReturn { get; set; }
    }

    public partial class MonthlyTotReturnElement
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public MonthlyTotReturn Empty { get; set; }
    }

    public partial class MonthlyTotReturn
    {
        [JsonProperty("classId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClassId { get; set; }

        [JsonProperty("rtn1", NullValueHandling = NullValueHandling.Ignore)]
        public string Rtn1 { get; set; }

        [JsonProperty("rtn2", NullValueHandling = NullValueHandling.Ignore)]
        public string Rtn2 { get; set; }

        [JsonProperty("rtn3", NullValueHandling = NullValueHandling.Ignore)]
        public string Rtn3 { get; set; }
    }

    public partial class GenInfo
    {
        [JsonProperty("regName", NullValueHandling = NullValueHandling.Ignore)]
        public string RegName { get; set; }

        [JsonProperty("regFileNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string RegFileNumber { get; set; }

        [JsonProperty("regCik", NullValueHandling = NullValueHandling.Ignore)]
        public string RegCik { get; set; }

        [JsonProperty("regLei", NullValueHandling = NullValueHandling.Ignore)]
        public string RegLei { get; set; }

        [JsonProperty("regStreet1", NullValueHandling = NullValueHandling.Ignore)]
        public string RegStreet1 { get; set; }

        [JsonProperty("regStreet2", NullValueHandling = NullValueHandling.Ignore)]
        public string RegStreet2 { get; set; }

        [JsonProperty("regCity", NullValueHandling = NullValueHandling.Ignore)]
        public string RegCity { get; set; }

        [JsonProperty("regStateConditional", NullValueHandling = NullValueHandling.Ignore)]
        public RegStateConditionalClass RegStateConditional { get; set; }

        [JsonProperty("regZipOrPostalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string RegZipOrPostalCode { get; set; }

        [JsonProperty("regPhone", NullValueHandling = NullValueHandling.Ignore)]
        public string RegPhone { get; set; }

        [JsonProperty("seriesName", NullValueHandling = NullValueHandling.Ignore)]
        public string SeriesName { get; set; }

        [JsonProperty("seriesId", NullValueHandling = NullValueHandling.Ignore)]
        public string SeriesId { get; set; }

        [JsonProperty("seriesLei", NullValueHandling = NullValueHandling.Ignore)]
        public string SeriesLei { get; set; }

        [JsonProperty("repPdEnd", NullValueHandling = NullValueHandling.Ignore)]
        public string RepPdEnd { get; set; }

        [JsonProperty("repPdDate", NullValueHandling = NullValueHandling.Ignore)]
        public string RepPdDate { get; set; }

        [JsonProperty("isFinalFiling", NullValueHandling = NullValueHandling.Ignore)]
        public string IsFinalFiling { get; set; }
    }

    public partial class RegStateConditionalClass
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public RegStateConditional Empty { get; set; }
    }

    public partial class RegStateConditional
    {
        [JsonProperty("regCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string RegCountry { get; set; }

        [JsonProperty("regState", NullValueHandling = NullValueHandling.Ignore)]
        public string RegState { get; set; }
    }

    public partial class InvstOrSecs
    {
        [JsonProperty("invstOrSec", NullValueHandling = NullValueHandling.Ignore)]
        public object InvstOrSec { get; set; }
    }

    public partial class InvstOrSec
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("lei", NullValueHandling = NullValueHandling.Ignore)]
        public string Lei { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("cusip", NullValueHandling = NullValueHandling.Ignore)]
        public string Cusip { get; set; }

        [JsonProperty("identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public InvstOrSecIdentifiers Identifiers { get; set; }

        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public string Balance { get; set; }

        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
        public string Units { get; set; }

        [JsonProperty("curCd", NullValueHandling = NullValueHandling.Ignore)]
        public string CurCd { get; set; }

        [JsonProperty("valUSD", NullValueHandling = NullValueHandling.Ignore)]
        public string ValUsd { get; set; }

        [JsonProperty("pctVal", NullValueHandling = NullValueHandling.Ignore)]
        public string PctVal { get; set; }

        [JsonProperty("payoffProfile", NullValueHandling = NullValueHandling.Ignore)]
        public string PayoffProfile { get; set; }

        [JsonProperty("assetCat", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetCat { get; set; }

        [JsonProperty("issuerCat", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerCat { get; set; }

        [JsonProperty("invCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string InvCountry { get; set; }

        [JsonProperty("isRestrictedSec", NullValueHandling = NullValueHandling.Ignore)]
        public string IsRestrictedSec { get; set; }

        [JsonProperty("fairValLevel", NullValueHandling = NullValueHandling.Ignore)]
        public string FairValLevel { get; set; }

        [JsonProperty("debtSec", NullValueHandling = NullValueHandling.Ignore)]
        public DebtSec DebtSec { get; set; }

        [JsonProperty("securityLending", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityLending SecurityLending { get; set; }

        [JsonProperty("descOthUnits", NullValueHandling = NullValueHandling.Ignore)]
        public string DescOthUnits { get; set; }

        [JsonProperty("issuerConditional", NullValueHandling = NullValueHandling.Ignore)]
        public IssuerConditionalClass IssuerConditional { get; set; }

        [JsonProperty("derivativeInfo", NullValueHandling = NullValueHandling.Ignore)]
        public DerivativeInfo DerivativeInfo { get; set; }

        [JsonProperty("currencyConditional", NullValueHandling = NullValueHandling.Ignore)]
        public CurrencyConditionalClass CurrencyConditional { get; set; }

        [JsonProperty("repurchaseAgrmt", NullValueHandling = NullValueHandling.Ignore)]
        public RepurchaseAgrmt RepurchaseAgrmt { get; set; }
    }

    public partial class CurrencyConditionalClass
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public CurrencyConditional Empty { get; set; }
    }

    public partial class CurrencyConditional
    {
        [JsonProperty("curCd", NullValueHandling = NullValueHandling.Ignore)]
        public string CurCd { get; set; }

        [JsonProperty("exchangeRt", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchangeRt { get; set; }
    }

    public partial class DebtSec
    {
        [JsonProperty("maturityDt", NullValueHandling = NullValueHandling.Ignore)]
        public string MaturityDt { get; set; }

        [JsonProperty("couponKind", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponKind { get; set; }

        [JsonProperty("annualizedRt", NullValueHandling = NullValueHandling.Ignore)]
        public string AnnualizedRt { get; set; }

        [JsonProperty("isDefault", NullValueHandling = NullValueHandling.Ignore)]
        public string IsDefault { get; set; }

        [JsonProperty("areIntrstPmntsInArrs", NullValueHandling = NullValueHandling.Ignore)]
        public string AreIntrstPmntsInArrs { get; set; }

        [JsonProperty("isPaidKind", NullValueHandling = NullValueHandling.Ignore)]
        public string IsPaidKind { get; set; }
    }

    public partial class DerivativeInfo
    {
        [JsonProperty("swapDeriv", NullValueHandling = NullValueHandling.Ignore)]
        public DerivativeInfoSwapDeriv SwapDeriv { get; set; }

        [JsonProperty("futrDeriv", NullValueHandling = NullValueHandling.Ignore)]
        public FutrDerivClass FutrDeriv { get; set; }

        [JsonProperty("fwdDeriv", NullValueHandling = NullValueHandling.Ignore)]
        public FwdDeriv FwdDeriv { get; set; }

        [JsonProperty("optionSwaptionWarrantDeriv", NullValueHandling = NullValueHandling.Ignore)]
        public OptionSwaptionWarrantDeriv OptionSwaptionWarrantDeriv { get; set; }
    }

    public partial class FutrDerivClass
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public FutrDeriv Empty { get; set; }

        [JsonProperty("counterparties", NullValueHandling = NullValueHandling.Ignore)]
        public Counterparties Counterparties { get; set; }

        [JsonProperty("payOffProf", NullValueHandling = NullValueHandling.Ignore)]
        public string PayOffProf { get; set; }

        [JsonProperty("descRefInstrmnt", NullValueHandling = NullValueHandling.Ignore)]
        public FutrDerivDescRefInstrmnt DescRefInstrmnt { get; set; }

        [JsonProperty("expDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpDate { get; set; }

        [JsonProperty("notionalAmt", NullValueHandling = NullValueHandling.Ignore)]
        public string NotionalAmt { get; set; }

        [JsonProperty("curCd", NullValueHandling = NullValueHandling.Ignore)]
        public string CurCd { get; set; }

        [JsonProperty("unrealizedAppr", NullValueHandling = NullValueHandling.Ignore)]
        public string UnrealizedAppr { get; set; }
    }

    public partial class Counterparties
    {
        [JsonProperty("counterpartyName", NullValueHandling = NullValueHandling.Ignore)]
        public string CounterpartyName { get; set; }

        [JsonProperty("counterpartyLei", NullValueHandling = NullValueHandling.Ignore)]
        public string CounterpartyLei { get; set; }
    }

    public partial class FutrDerivDescRefInstrmnt
    {
        [JsonProperty("indexBasketInfo", NullValueHandling = NullValueHandling.Ignore)]
        public IndexBasketInfo IndexBasketInfo { get; set; }
    }

    public partial class IndexBasketInfo
    {
        [JsonProperty("indexName", NullValueHandling = NullValueHandling.Ignore)]
        public string IndexName { get; set; }

        [JsonProperty("indexIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public string IndexIdentifier { get; set; }
    }

    public partial class FutrDeriv
    {
        [JsonProperty("derivCat", NullValueHandling = NullValueHandling.Ignore)]
        public string DerivCat { get; set; }
    }

    public partial class FwdDeriv
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public FutrDeriv Empty { get; set; }

        [JsonProperty("counterparties", NullValueHandling = NullValueHandling.Ignore)]
        public Counterparties Counterparties { get; set; }

        [JsonProperty("amtCurSold", NullValueHandling = NullValueHandling.Ignore)]
        public string AmtCurSold { get; set; }

        [JsonProperty("curSold", NullValueHandling = NullValueHandling.Ignore)]
        public string CurSold { get; set; }

        [JsonProperty("amtCurPur", NullValueHandling = NullValueHandling.Ignore)]
        public string AmtCurPur { get; set; }

        [JsonProperty("curPur", NullValueHandling = NullValueHandling.Ignore)]
        public string CurPur { get; set; }

        [JsonProperty("settlementDt", NullValueHandling = NullValueHandling.Ignore)]
        public string SettlementDt { get; set; }

        [JsonProperty("unrealizedAppr", NullValueHandling = NullValueHandling.Ignore)]
        public string UnrealizedAppr { get; set; }
    }

    public partial class OptionSwaptionWarrantDeriv
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public FutrDeriv Empty { get; set; }

        [JsonProperty("counterparties", NullValueHandling = NullValueHandling.Ignore)]
        public Counterparties Counterparties { get; set; }

        [JsonProperty("putOrCall", NullValueHandling = NullValueHandling.Ignore)]
        public string PutOrCall { get; set; }

        [JsonProperty("writtenOrPur", NullValueHandling = NullValueHandling.Ignore)]
        public string WrittenOrPur { get; set; }

        [JsonProperty("descRefInstrmnt", NullValueHandling = NullValueHandling.Ignore)]
        public OptionSwaptionWarrantDerivDescRefInstrmnt DescRefInstrmnt { get; set; }

        [JsonProperty("shareNo", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareNo { get; set; }

        [JsonProperty("exercisePrice", NullValueHandling = NullValueHandling.Ignore)]
        public string ExercisePrice { get; set; }

        [JsonProperty("exercisePriceCurCd", NullValueHandling = NullValueHandling.Ignore)]
        public string ExercisePriceCurCd { get; set; }

        [JsonProperty("expDt", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpDt { get; set; }

        [JsonProperty("delta", NullValueHandling = NullValueHandling.Ignore)]
        public string Delta { get; set; }

        [JsonProperty("unrealizedAppr", NullValueHandling = NullValueHandling.Ignore)]
        public string UnrealizedAppr { get; set; }
    }

    public partial class OptionSwaptionWarrantDerivDescRefInstrmnt
    {
        [JsonProperty("nestedDerivInfo", NullValueHandling = NullValueHandling.Ignore)]
        public NestedDerivInfo NestedDerivInfo { get; set; }
    }

    public partial class NestedDerivInfo
    {
        [JsonProperty("swapDeriv", NullValueHandling = NullValueHandling.Ignore)]
        public NestedDerivInfoSwapDeriv SwapDeriv { get; set; }
    }

    public partial class NestedDerivInfoSwapDeriv
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public FutrDeriv Empty { get; set; }

        [JsonProperty("counterparties", NullValueHandling = NullValueHandling.Ignore)]
        public Counterparties Counterparties { get; set; }

        [JsonProperty("derivAddlInfo", NullValueHandling = NullValueHandling.Ignore)]
        public DerivAddlInfo DerivAddlInfo { get; set; }

        [JsonProperty("descRefInstrmnt", NullValueHandling = NullValueHandling.Ignore)]
        public FutrDerivDescRefInstrmnt DescRefInstrmnt { get; set; }

        [JsonProperty("floatingRecDesc", NullValueHandling = NullValueHandling.Ignore)]
        public FloatingDesc FloatingRecDesc { get; set; }

        [JsonProperty("fixedPmntDesc", NullValueHandling = NullValueHandling.Ignore)]
        public FixedDesc FixedPmntDesc { get; set; }

        [JsonProperty("terminationDt", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminationDt { get; set; }

        [JsonProperty("upfrontPmnt", NullValueHandling = NullValueHandling.Ignore)]
        public string UpfrontPmnt { get; set; }

        [JsonProperty("pmntCurCd", NullValueHandling = NullValueHandling.Ignore)]
        public string PmntCurCd { get; set; }

        [JsonProperty("upfrontRcpt", NullValueHandling = NullValueHandling.Ignore)]
        public string UpfrontRcpt { get; set; }

        [JsonProperty("rcptCurCd", NullValueHandling = NullValueHandling.Ignore)]
        public string RcptCurCd { get; set; }

        [JsonProperty("notionalAmt", NullValueHandling = NullValueHandling.Ignore)]
        public string NotionalAmt { get; set; }

        [JsonProperty("curCd", NullValueHandling = NullValueHandling.Ignore)]
        public string CurCd { get; set; }
    }

    public partial class DerivAddlInfo
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("lei", NullValueHandling = NullValueHandling.Ignore)]
        public string Lei { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("cusip", NullValueHandling = NullValueHandling.Ignore)]
        public string Cusip { get; set; }

        [JsonProperty("identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public DerivAddlInfoIdentifiers Identifiers { get; set; }

        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public string Balance { get; set; }

        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
        public string Units { get; set; }

        [JsonProperty("descOthUnits", NullValueHandling = NullValueHandling.Ignore)]
        public string DescOthUnits { get; set; }

        [JsonProperty("curCd", NullValueHandling = NullValueHandling.Ignore)]
        public string CurCd { get; set; }

        [JsonProperty("valUSD", NullValueHandling = NullValueHandling.Ignore)]
        public string ValUsd { get; set; }

        [JsonProperty("pctVal", NullValueHandling = NullValueHandling.Ignore)]
        public string PctVal { get; set; }

        [JsonProperty("assetCat", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetCat { get; set; }

        [JsonProperty("issuerConditional", NullValueHandling = NullValueHandling.Ignore)]
        public IssuerConditionalClass IssuerConditional { get; set; }

        [JsonProperty("invCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string InvCountry { get; set; }
    }

    public partial class DerivAddlInfoIdentifiers
    {
        [JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
        public OtherClass Other { get; set; }
    }

    public partial class OtherClass
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public Other Empty { get; set; }
    }

    public partial class Other
    {
        [JsonProperty("otherDesc", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherDesc { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class IssuerConditionalClass
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public IssuerConditional Empty { get; set; }
    }

    public partial class IssuerConditional
    {
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        [JsonProperty("issuerCat", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerCat { get; set; }
    }

    public partial class FixedDesc
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public FixedPmntDesc Empty { get; set; }
    }

    public partial class FixedPmntDesc
    {
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        [JsonProperty("curCd", NullValueHandling = NullValueHandling.Ignore)]
        public string CurCd { get; set; }

        [JsonProperty("fixedOrFloating", NullValueHandling = NullValueHandling.Ignore)]
        public string FixedOrFloating { get; set; }

        [JsonProperty("fixedRt", NullValueHandling = NullValueHandling.Ignore)]
        public string FixedRt { get; set; }
    }

    public partial class FloatingDesc
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public FloatingPmntDesc Empty { get; set; }

        [JsonProperty("rtResetTenors", NullValueHandling = NullValueHandling.Ignore)]
        public RtResetTenors RtResetTenors { get; set; }
    }

    public partial class FloatingPmntDesc
    {
        [JsonProperty("curCd", NullValueHandling = NullValueHandling.Ignore)]
        public string CurCd { get; set; }

        [JsonProperty("fixedOrFloating", NullValueHandling = NullValueHandling.Ignore)]
        public string FixedOrFloating { get; set; }

        [JsonProperty("floatingRtIndex", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingRtIndex { get; set; }

        [JsonProperty("floatingRtSpread", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingRtSpread { get; set; }

        [JsonProperty("pmntAmt", NullValueHandling = NullValueHandling.Ignore)]
        public string PmntAmt { get; set; }
    }

    public partial class RtResetTenors
    {
        [JsonProperty("rtResetTenor", NullValueHandling = NullValueHandling.Ignore)]
        public RtResetTenorClass RtResetTenor { get; set; }
    }

    public partial class RtResetTenorClass
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public RtResetTenor Empty { get; set; }
    }

    public partial class RtResetTenor
    {
        [JsonProperty("rateTenor", NullValueHandling = NullValueHandling.Ignore)]
        public string RateTenor { get; set; }

        [JsonProperty("rateTenorUnit", NullValueHandling = NullValueHandling.Ignore)]
        public string RateTenorUnit { get; set; }

        [JsonProperty("resetDt", NullValueHandling = NullValueHandling.Ignore)]
        public string ResetDt { get; set; }

        [JsonProperty("resetDtUnit", NullValueHandling = NullValueHandling.Ignore)]
        public string ResetDtUnit { get; set; }
    }

    public partial class DerivativeInfoSwapDeriv
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public FutrDeriv Empty { get; set; }

        [JsonProperty("counterparties", NullValueHandling = NullValueHandling.Ignore)]
        public Counterparties Counterparties { get; set; }

        [JsonProperty("descRefInstrmnt", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleDescRefInstrmnt DescRefInstrmnt { get; set; }

        [JsonProperty("swapFlag", NullValueHandling = NullValueHandling.Ignore)]
        public string SwapFlag { get; set; }

        [JsonProperty("fixedRecDesc", NullValueHandling = NullValueHandling.Ignore)]
        public FixedDesc FixedRecDesc { get; set; }

        [JsonProperty("otherPmntDesc", NullValueHandling = NullValueHandling.Ignore)]
        public OtherDesc OtherPmntDesc { get; set; }

        [JsonProperty("terminationDt", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminationDt { get; set; }

        [JsonProperty("upfrontPmnt", NullValueHandling = NullValueHandling.Ignore)]
        public string UpfrontPmnt { get; set; }

        [JsonProperty("pmntCurCd", NullValueHandling = NullValueHandling.Ignore)]
        public string PmntCurCd { get; set; }

        [JsonProperty("upfrontRcpt", NullValueHandling = NullValueHandling.Ignore)]
        public string UpfrontRcpt { get; set; }

        [JsonProperty("rcptCurCd", NullValueHandling = NullValueHandling.Ignore)]
        public string RcptCurCd { get; set; }

        [JsonProperty("notionalAmt", NullValueHandling = NullValueHandling.Ignore)]
        public string NotionalAmt { get; set; }

        [JsonProperty("curCd", NullValueHandling = NullValueHandling.Ignore)]
        public string CurCd { get; set; }

        [JsonProperty("unrealizedAppr", NullValueHandling = NullValueHandling.Ignore)]
        public string UnrealizedAppr { get; set; }

        [JsonProperty("floatingRecDesc", NullValueHandling = NullValueHandling.Ignore)]
        public FloatingDesc FloatingRecDesc { get; set; }

        [JsonProperty("fixedPmntDesc", NullValueHandling = NullValueHandling.Ignore)]
        public FixedDesc FixedPmntDesc { get; set; }

        [JsonProperty("otherRecDesc", NullValueHandling = NullValueHandling.Ignore)]
        public OtherDesc OtherRecDesc { get; set; }

        [JsonProperty("floatingPmntDesc", NullValueHandling = NullValueHandling.Ignore)]
        public FloatingDesc FloatingPmntDesc { get; set; }
    }

    public partial class PurpleDescRefInstrmnt
    {
        [JsonProperty("indexBasketInfo", NullValueHandling = NullValueHandling.Ignore)]
        public IndexBasketInfo IndexBasketInfo { get; set; }

        [JsonProperty("otherRefInst", NullValueHandling = NullValueHandling.Ignore)]
        public OtherRefInst OtherRefInst { get; set; }
    }

    public partial class OtherRefInst
    {
        [JsonProperty("issuerName", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuerName { get; set; }

        [JsonProperty("issueTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueTitle { get; set; }

        [JsonProperty("identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public OtherRefInstIdentifiers Identifiers { get; set; }
    }

    public partial class OtherRefInstIdentifiers
    {
        [JsonProperty("cusip", NullValueHandling = NullValueHandling.Ignore)]
        public IsinClass Cusip { get; set; }

        [JsonProperty("isin", NullValueHandling = NullValueHandling.Ignore)]
        public IsinClass Isin { get; set; }
    }

    public partial class IsinClass
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public Isin Empty { get; set; }
    }

    public partial class Isin
    {
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class OtherDesc
    {
        [JsonProperty("_", NullValueHandling = NullValueHandling.Ignore)]
        public string Purple { get; set; }

        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public OtherPmntDesc Empty { get; set; }
    }

    public partial class OtherPmntDesc
    {
        [JsonProperty("fixedOrFloating", NullValueHandling = NullValueHandling.Ignore)]
        public string FixedOrFloating { get; set; }
    }

    public partial class InvstOrSecIdentifiers
    {
        [JsonProperty("isin", NullValueHandling = NullValueHandling.Ignore)]
        public IsinClass Isin { get; set; }

        [JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
        public OtherClass Other { get; set; }
    }

    public partial class RepurchaseAgrmt
    {
        [JsonProperty("transCat", NullValueHandling = NullValueHandling.Ignore)]
        public string TransCat { get; set; }

        [JsonProperty("notClearedCentCparty", NullValueHandling = NullValueHandling.Ignore)]
        public NotClearedCentCpartyClass NotClearedCentCparty { get; set; }

        [JsonProperty("isTriParty", NullValueHandling = NullValueHandling.Ignore)]
        public string IsTriParty { get; set; }

        [JsonProperty("repurchaseRt", NullValueHandling = NullValueHandling.Ignore)]
        public string RepurchaseRt { get; set; }

        [JsonProperty("maturityDt", NullValueHandling = NullValueHandling.Ignore)]
        public string MaturityDt { get; set; }

        [JsonProperty("repurchaseCollaterals", NullValueHandling = NullValueHandling.Ignore)]
        public RepurchaseCollaterals RepurchaseCollaterals { get; set; }
    }

    public partial class NotClearedCentCpartyClass
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public NotClearedCentCparty Empty { get; set; }

        [JsonProperty("counterpartyInfos", NullValueHandling = NullValueHandling.Ignore)]
        public CounterpartyInfos CounterpartyInfos { get; set; }
    }

    public partial class CounterpartyInfos
    {
        [JsonProperty("counterpartyInfo", NullValueHandling = NullValueHandling.Ignore)]
        public CounterpartyInfoClass CounterpartyInfo { get; set; }
    }

    public partial class CounterpartyInfoClass
    {
        [JsonProperty("$", NullValueHandling = NullValueHandling.Ignore)]
        public CounterpartyInfo Empty { get; set; }
    }

    public partial class CounterpartyInfo
    {
        [JsonProperty("lei", NullValueHandling = NullValueHandling.Ignore)]
        public string Lei { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public partial class NotClearedCentCparty
    {
        [JsonProperty("isCleared", NullValueHandling = NullValueHandling.Ignore)]
        public string IsCleared { get; set; }
    }

    public partial class RepurchaseCollaterals
    {
        [JsonProperty("repurchaseCollateral", NullValueHandling = NullValueHandling.Ignore)]
        public RepurchaseCollateral RepurchaseCollateral { get; set; }
    }

    public partial class RepurchaseCollateral
    {
        [JsonProperty("principalAmt", NullValueHandling = NullValueHandling.Ignore)]
        public string PrincipalAmt { get; set; }

        [JsonProperty("principalCd", NullValueHandling = NullValueHandling.Ignore)]
        public string PrincipalCd { get; set; }

        [JsonProperty("collateralVal", NullValueHandling = NullValueHandling.Ignore)]
        public string CollateralVal { get; set; }

        [JsonProperty("collateralCd", NullValueHandling = NullValueHandling.Ignore)]
        public string CollateralCd { get; set; }

        [JsonProperty("invstCat", NullValueHandling = NullValueHandling.Ignore)]
        public string InvstCat { get; set; }
    }

    public partial class SecurityLending
    {
        [JsonProperty("isCashCollateral", NullValueHandling = NullValueHandling.Ignore)]
        public string IsCashCollateral { get; set; }

        [JsonProperty("isNonCashCollateral", NullValueHandling = NullValueHandling.Ignore)]
        public string IsNonCashCollateral { get; set; }

        [JsonProperty("isLoanByFund", NullValueHandling = NullValueHandling.Ignore)]
        public string IsLoanByFund { get; set; }
    }

    public partial class Signature
    {
        [JsonProperty("ncom:dateSigned", NullValueHandling = NullValueHandling.Ignore)]
        public string NcomDateSigned { get; set; }

        [JsonProperty("ncom:nameOfApplicant", NullValueHandling = NullValueHandling.Ignore)]
        public string NcomNameOfApplicant { get; set; }

        [JsonProperty("ncom:signature", NullValueHandling = NullValueHandling.Ignore)]
        public string NcomSignature { get; set; }

        [JsonProperty("ncom:signerName", NullValueHandling = NullValueHandling.Ignore)]
        public string NcomSignerName { get; set; }

        [JsonProperty("ncom:title", NullValueHandling = NullValueHandling.Ignore)]
        public string NcomTitle { get; set; }
    }

    public partial class HeaderData
    {
        [JsonProperty("submissionType", NullValueHandling = NullValueHandling.Ignore)]
        public string SubmissionType { get; set; }

        [JsonProperty("isConfidential", NullValueHandling = NullValueHandling.Ignore)]
        public string IsConfidential { get; set; }

        [JsonProperty("filerInfo", NullValueHandling = NullValueHandling.Ignore)]
        public FilerInfo FilerInfo { get; set; }
    }

    public partial class FilerInfo
    {
        [JsonProperty("filer", NullValueHandling = NullValueHandling.Ignore)]
        public Filer Filer { get; set; }

        [JsonProperty("seriesClassInfo", NullValueHandling = NullValueHandling.Ignore)]
        public SeriesClassInfo SeriesClassInfo { get; set; }
    }

    public partial class Filer
    {
        [JsonProperty("issuerCredentials", NullValueHandling = NullValueHandling.Ignore)]
        public IssuerCredentials IssuerCredentials { get; set; }
    }

    public partial class IssuerCredentials
    {
        [JsonProperty("cik", NullValueHandling = NullValueHandling.Ignore)]
        public string Cik { get; set; }

        [JsonProperty("ccc", NullValueHandling = NullValueHandling.Ignore)]
        public string Ccc { get; set; }
    }

    public partial class SeriesClassInfo
    {
        [JsonProperty("seriesId", NullValueHandling = NullValueHandling.Ignore)]
        public string SeriesId { get; set; }

        [JsonProperty("classId", NullValueHandling = NullValueHandling.Ignore)]
        public object ClassId { get; set; }
    }
}
