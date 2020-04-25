using System;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WSBNports.Models
{


    public partial class Welcome
    {
        [JsonProperty("edgarSubmission")]
        public Nport EdgarSubmission { get; set; }
    }

    public partial class Nport : Entity
    {
        [JsonProperty("$")]
        public EdgarSubmissionClass Empty { get; set; }

        [JsonProperty("headerData")]
        public HeaderData HeaderData { get; set; }

        [JsonProperty("formData")]
        public FormData FormData { get; set; }
    }

    public partial class EdgarSubmissionClass
    {
        [JsonProperty("xmlns")]
        public Uri Xmlns { get; set; }

        [JsonProperty("xmlns:com")]
        public Uri XmlnsCom { get; set; }

        [JsonProperty("xmlns:ncom")]
        public Uri XmlnsNcom { get; set; }

        [JsonProperty("xmlns:xsi")]
        public Uri XmlnsXsi { get; set; }

        [JsonProperty("xsi:schemaLocation")]
        public Uri XsiSchemaLocation { get; set; }
    }

    public partial class FormData
    {
        [JsonProperty("genInfo")]
        public GenInfo GenInfo { get; set; }

        [JsonProperty("fundInfo")]
        public FundInfo FundInfo { get; set; }

        [JsonProperty("invstOrSecs")]
        public InvstOrSecs InvstOrSecs { get; set; }

        [JsonProperty("signature")]
        public Signature Signature { get; set; }
    }

    public partial class FundInfo
    {
        [JsonProperty("totAssets")]
        public string TotAssets { get; set; }

        [JsonProperty("totLiabs")]
        public string TotLiabs { get; set; }

        [JsonProperty("netAssets")]
        public string NetAssets { get; set; }

        [JsonProperty("assetsAttrMiscSec")]
        public string AssetsAttrMiscSec { get; set; }

        [JsonProperty("assetsInvested")]
        public string AssetsInvested { get; set; }

        [JsonProperty("amtPayOneYrBanksBorr")]
        public string AmtPayOneYrBanksBorr { get; set; }

        [JsonProperty("amtPayOneYrCtrldComp")]
        public string AmtPayOneYrCtrldComp { get; set; }

        [JsonProperty("amtPayOneYrOthAffil")]
        public string AmtPayOneYrOthAffil { get; set; }

        [JsonProperty("amtPayOneYrOther")]
        public string AmtPayOneYrOther { get; set; }

        [JsonProperty("amtPayAftOneYrBanksBorr")]
        public string AmtPayAftOneYrBanksBorr { get; set; }

        [JsonProperty("amtPayAftOneYrCtrldComp")]
        public string AmtPayAftOneYrCtrldComp { get; set; }

        [JsonProperty("amtPayAftOneYrOthAffil")]
        public string AmtPayAftOneYrOthAffil { get; set; }

        [JsonProperty("amtPayAftOneYrOther")]
        public string AmtPayAftOneYrOther { get; set; }

        [JsonProperty("delayDeliv")]
        public string DelayDeliv { get; set; }

        [JsonProperty("standByCommit")]
        public string StandByCommit { get; set; }

        [JsonProperty("liquidPref")]
        public string LiquidPref { get; set; }

        [JsonProperty("cshNotRptdInCorD")]
        public string CshNotRptdInCorD { get; set; }

        [JsonProperty("isNonCashCollateral")]
        public Is IsNonCashCollateral { get; set; }

        [JsonProperty("returnInfo")]
        public ReturnInfo ReturnInfo { get; set; }

        [JsonProperty("mon1Flow")]
        public MonFlow Mon1Flow { get; set; }

        [JsonProperty("mon2Flow")]
        public MonFlow Mon2Flow { get; set; }

        [JsonProperty("mon3Flow")]
        public MonFlow Mon3Flow { get; set; }
    }

    public partial class MonFlow
    {
        [JsonProperty("$")]
        public Mon1Flow Empty { get; set; }
    }

    public partial class Mon1Flow
    {
        [JsonProperty("redemption")]
        public string Redemption { get; set; }

        [JsonProperty("reinvestment")]
        public string Reinvestment { get; set; }

        [JsonProperty("sales")]
        public string Sales { get; set; }
    }

    public partial class ReturnInfo
    {
        [JsonProperty("monthlyTotReturns")]
        public MonthlyTotReturns MonthlyTotReturns { get; set; }

        [JsonProperty("monthlyReturnCats")]
        public MonthlyReturnCats MonthlyReturnCats { get; set; }

        [JsonProperty("othMon1")]
        public OthMon1Class OthMon1 { get; set; }

        [JsonProperty("othMon2")]
        public OthMon1Class OthMon2 { get; set; }

        [JsonProperty("othMon3")]
        public OthMon1Class OthMon3 { get; set; }
    }

    public partial class MonthlyReturnCats
    {
        [JsonProperty("commodityContracts")]
        public Contracts CommodityContracts { get; set; }

        [JsonProperty("creditContracts")]
        public Contracts CreditContracts { get; set; }

        [JsonProperty("equityContracts")]
        public Contracts EquityContracts { get; set; }

        [JsonProperty("foreignExchgContracts")]
        public Contracts ForeignExchgContracts { get; set; }

        [JsonProperty("interestRtContracts")]
        public Contracts InterestRtContracts { get; set; }

        [JsonProperty("otherContracts")]
        public Contracts OtherContracts { get; set; }
    }

    public partial class Contracts
    {
        [JsonProperty("mon1")]
        public OthMon1Class Mon1 { get; set; }

        [JsonProperty("mon2")]
        public OthMon1Class Mon2 { get; set; }

        [JsonProperty("mon3")]
        public OthMon1Class Mon3 { get; set; }

        [JsonProperty("forwardCategory")]
        public Category ForwardCategory { get; set; }

        [JsonProperty("futureCategory")]
        public Category FutureCategory { get; set; }

        [JsonProperty("optionCategory")]
        public Category OptionCategory { get; set; }

        [JsonProperty("swaptionCategory")]
        public Category SwaptionCategory { get; set; }

        [JsonProperty("swapCategory")]
        public Category SwapCategory { get; set; }

        [JsonProperty("warrantCategory")]
        public Category WarrantCategory { get; set; }

        [JsonProperty("otherCategory")]
        public Category OtherCategory { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("instrMon1")]
        public OthMon1Class InstrMon1 { get; set; }

        [JsonProperty("instrMon2")]
        public OthMon1Class InstrMon2 { get; set; }

        [JsonProperty("instrMon3")]
        public OthMon1Class InstrMon3 { get; set; }
    }

    public partial class OthMon1Class
    {
        [JsonProperty("$")]
        public OthMon1 Empty { get; set; }
    }

    public partial class OthMon1
    {
        [JsonProperty("netRealizedGain")]
        public string NetRealizedGain { get; set; }

        [JsonProperty("netUnrealizedAppr")]
        public string NetUnrealizedAppr { get; set; }
    }

    public partial class MonthlyTotReturns
    {
        [JsonProperty("monthlyTotReturn")]
        public MonthlyTotReturnClass MonthlyTotReturn { get; set; }
    }

    public partial class MonthlyTotReturnClass
    {
        [JsonProperty("$")]
        public MonthlyTotReturn Empty { get; set; }
    }

    public partial class MonthlyTotReturn
    {
        [JsonProperty("classId")]
        public string ClassId { get; set; }

        [JsonProperty("rtn1")]
        public string Rtn1 { get; set; }

        [JsonProperty("rtn2")]
        public string Rtn2 { get; set; }

        [JsonProperty("rtn3")]
        public string Rtn3 { get; set; }
    }

    public partial class GenInfo
    {
        [JsonProperty("regName")]
        public string RegName { get; set; }

        [JsonProperty("regFileNumber")]
        public string RegFileNumber { get; set; }

        [JsonProperty("regCik")]
        public string RegCik { get; set; }

        [JsonProperty("regLei")]
        public string RegLei { get; set; }

        [JsonProperty("regStreet1")]
        public string RegStreet1 { get; set; }

        [JsonProperty("regCity")]
        public string RegCity { get; set; }

        [JsonProperty("regStateConditional")]
        public RegStateConditionalClass RegStateConditional { get; set; }

        [JsonProperty("regZipOrPostalCode")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long RegZipOrPostalCode { get; set; }

        [JsonProperty("regPhone")]
        public string RegPhone { get; set; }

        [JsonProperty("seriesName")]
        public string SeriesName { get; set; }

        [JsonProperty("seriesId")]
        public string SeriesId { get; set; }

        [JsonProperty("seriesLei")]
        public string SeriesLei { get; set; }

        [JsonProperty("repPdEnd")]
        public DateTimeOffset RepPdEnd { get; set; }

        [JsonProperty("repPdDate")]
        public DateTimeOffset RepPdDate { get; set; }

        [JsonProperty("isFinalFiling")]
        public Is IsFinalFiling { get; set; }
    }

    public partial class RegStateConditionalClass
    {
        [JsonProperty("$")]
        public RegStateConditional Empty { get; set; }
    }

    public partial class RegStateConditional
    {
        [JsonProperty("regCountry")]
        public Country RegCountry { get; set; }

        [JsonProperty("regState")]
        public string RegState { get; set; }
    }

    public partial class InvstOrSecs
    {
        [JsonProperty("invstOrSec")]
        public InvstOrSec[] InvstOrSec { get; set; }
    }

    public partial class InvstOrSec
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lei")]
        public string Lei { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("identifiers")]
        public Identifiers Identifiers { get; set; }

        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("units")]
        public Units Units { get; set; }

        [JsonProperty("curCd")]
        public CurCd CurCd { get; set; }

        [JsonProperty("valUSD")]
        public string ValUsd { get; set; }

        [JsonProperty("pctVal")]
        public string PctVal { get; set; }

        [JsonProperty("payoffProfile")]
        public PayoffProfile PayoffProfile { get; set; }

        [JsonProperty("assetConditional")]
        public AssetConditionalClass AssetConditional { get; set; }

        [JsonProperty("issuerCat")]
        public IssuerCat IssuerCat { get; set; }

        [JsonProperty("invCountry")]
        public Country InvCountry { get; set; }

        [JsonProperty("isRestrictedSec")]
        public Is IsRestrictedSec { get; set; }

        [JsonProperty("fairValLevel")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long FairValLevel { get; set; }

        [JsonProperty("securityLending")]
        public SecurityLending SecurityLending { get; set; }
    }

    public partial class AssetConditionalClass
    {
        [JsonProperty("$")]
        public AssetConditional Empty { get; set; }
    }

    public partial class AssetConditional
    {
        [JsonProperty("assetCat")]
        public AssetCat AssetCat { get; set; }

        [JsonProperty("desc")]
        public Desc Desc { get; set; }
    }

    public partial class Identifiers
    {
        [JsonProperty("isin")]
        public IsinClass Isin { get; set; }
    }

    public partial class IsinClass
    {
        [JsonProperty("$")]
        public Isin Empty { get; set; }
    }

    public partial class Isin
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class SecurityLending
    {
        [JsonProperty("isCashCollateral")]
        public Is IsCashCollateral { get; set; }

        [JsonProperty("isNonCashCollateral")]
        public Is IsNonCashCollateral { get; set; }

        [JsonProperty("isLoanByFund")]
        public Is IsLoanByFund { get; set; }
    }

    public partial class Signature
    {
        [JsonProperty("ncom:dateSigned")]
        public DateTimeOffset NcomDateSigned { get; set; }

        [JsonProperty("ncom:nameOfApplicant")]
        public string NcomNameOfApplicant { get; set; }

        [JsonProperty("ncom:signature")]
        public string NcomSignature { get; set; }

        [JsonProperty("ncom:signerName")]
        public string NcomSignerName { get; set; }

        [JsonProperty("ncom:title")]
        public string NcomTitle { get; set; }
    }

    public partial class HeaderData
    {
        [JsonProperty("submissionType")]
        public string SubmissionType { get; set; }

        [JsonProperty("isConfidential")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool IsConfidential { get; set; }

        [JsonProperty("filerInfo")]
        public FilerInfo FilerInfo { get; set; }
    }

    public partial class FilerInfo
    {
        [JsonProperty("filer")]
        public Filer Filer { get; set; }

        [JsonProperty("seriesClassInfo")]
        public SeriesClassInfo SeriesClassInfo { get; set; }
    }

    public partial class Filer
    {
        [JsonProperty("issuerCredentials")]
        public IssuerCredentials IssuerCredentials { get; set; }
    }

    public partial class IssuerCredentials
    {
        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("ccc")]
        public string Ccc { get; set; }
    }

    public partial class SeriesClassInfo
    {
        [JsonProperty("seriesId")]
        public string SeriesId { get; set; }

        [JsonProperty("classId")]
        public string ClassId { get; set; }
    }

    public enum Is { N };

    public enum Country { Us };

    public enum AssetCat { Other };

    public enum Desc { ExchangeTradedFund };

    public enum CurCd { Usd };

    public enum IssuerCat { Rf };

    public enum PayoffProfile { Long };

    public enum Units { Ns };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                IsConverter.Singleton,
                CountryConverter.Singleton,
                AssetCatConverter.Singleton,
                DescConverter.Singleton,
                CurCdConverter.Singleton,
                IssuerCatConverter.Singleton,
                PayoffProfileConverter.Singleton,
                UnitsConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class IsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Is) || t == typeof(Is?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "N")
            {
                return Is.N;
            }
            throw new Exception("Cannot unmarshal type Is");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Is)untypedValue;
            if (value == Is.N)
            {
                serializer.Serialize(writer, "N");
                return;
            }
            throw new Exception("Cannot marshal type Is");
        }

        public static readonly IsConverter Singleton = new IsConverter();
    }

    internal class CountryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Country) || t == typeof(Country?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "US")
            {
                return Country.Us;
            }
            throw new Exception("Cannot unmarshal type Country");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Country)untypedValue;
            if (value == Country.Us)
            {
                serializer.Serialize(writer, "US");
                return;
            }
            throw new Exception("Cannot marshal type Country");
        }

        public static readonly CountryConverter Singleton = new CountryConverter();
    }

    internal class PurpleParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly PurpleParseStringConverter Singleton = new PurpleParseStringConverter();
    }

    internal class AssetCatConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AssetCat) || t == typeof(AssetCat?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "OTHER")
            {
                return AssetCat.Other;
            }
            throw new Exception("Cannot unmarshal type AssetCat");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AssetCat)untypedValue;
            if (value == AssetCat.Other)
            {
                serializer.Serialize(writer, "OTHER");
                return;
            }
            throw new Exception("Cannot marshal type AssetCat");
        }

        public static readonly AssetCatConverter Singleton = new AssetCatConverter();
    }

    internal class DescConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Desc) || t == typeof(Desc?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Exchange traded fund")
            {
                return Desc.ExchangeTradedFund;
            }
            throw new Exception("Cannot unmarshal type Desc");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Desc)untypedValue;
            if (value == Desc.ExchangeTradedFund)
            {
                serializer.Serialize(writer, "Exchange traded fund");
                return;
            }
            throw new Exception("Cannot marshal type Desc");
        }

        public static readonly DescConverter Singleton = new DescConverter();
    }

    internal class CurCdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CurCd) || t == typeof(CurCd?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "USD")
            {
                return CurCd.Usd;
            }
            throw new Exception("Cannot unmarshal type CurCd");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CurCd)untypedValue;
            if (value == CurCd.Usd)
            {
                serializer.Serialize(writer, "USD");
                return;
            }
            throw new Exception("Cannot marshal type CurCd");
        }

        public static readonly CurCdConverter Singleton = new CurCdConverter();
    }

    internal class IssuerCatConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IssuerCat) || t == typeof(IssuerCat?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "RF")
            {
                return IssuerCat.Rf;
            }
            throw new Exception("Cannot unmarshal type IssuerCat");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (IssuerCat)untypedValue;
            if (value == IssuerCat.Rf)
            {
                serializer.Serialize(writer, "RF");
                return;
            }
            throw new Exception("Cannot marshal type IssuerCat");
        }

        public static readonly IssuerCatConverter Singleton = new IssuerCatConverter();
    }

    internal class PayoffProfileConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PayoffProfile) || t == typeof(PayoffProfile?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Long")
            {
                return PayoffProfile.Long;
            }
            throw new Exception("Cannot unmarshal type PayoffProfile");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PayoffProfile)untypedValue;
            if (value == PayoffProfile.Long)
            {
                serializer.Serialize(writer, "Long");
                return;
            }
            throw new Exception("Cannot marshal type PayoffProfile");
        }

        public static readonly PayoffProfileConverter Singleton = new PayoffProfileConverter();
    }

    internal class UnitsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Units) || t == typeof(Units?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "NS")
            {
                return Units.Ns;
            }
            throw new Exception("Cannot unmarshal type Units");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Units)untypedValue;
            if (value == Units.Ns)
            {
                serializer.Serialize(writer, "NS");
                return;
            }
            throw new Exception("Cannot marshal type Units");
        }

        public static readonly UnitsConverter Singleton = new UnitsConverter();
    }

    internal class FluffyParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            bool b;
            if (Boolean.TryParse(value, out b))
            {
                return b;
            }
            throw new Exception("Cannot unmarshal type bool");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (bool)untypedValue;
            var boolString = value ? "true" : "false";
            serializer.Serialize(writer, boolString);
            return;
        }

        public static readonly FluffyParseStringConverter Singleton = new FluffyParseStringConverter();
    }


}
