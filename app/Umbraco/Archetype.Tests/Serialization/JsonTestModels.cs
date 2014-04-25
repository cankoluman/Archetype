﻿using System;
using System.Collections.Generic;
using Archetype.Umbraco.Serialization;
using Newtonsoft.Json;

namespace Archetype.Tests.Serialization
{
    #region json test Models

    [ArchetypeDatatype("urlPicker")]
    [JsonConverter(typeof(ArchetypeJsonConverter<UrlPicker>))]
    public class UrlPicker
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("content")]
        public int? Content { get; set; }
        [JsonProperty("media")]
        public int? Media { get; set; }
        [JsonProperty("openInNewWindow")]
        public bool OpenInNewWindow { get; set; }
    }

    [ArchetypeDatatype("contactDetails")]
    [JsonConverter(typeof(ArchetypeJsonConverter<ContactDetails>))]
    public class ContactDetails
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("telephone")]
        public string Telephone { get; set; }
        [JsonProperty("mobile")]
        public string Mobile { get; set; }
        [JsonProperty("fax")]
        public string Fax { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("webSite")]
        public UrlPicker WebSite { get; set; }
    }

    [ArchetypeDatatype("companyDetails")]
    [JsonConverter(typeof(ArchetypeJsonConverter<CompanyDetails>))]
    public class CompanyDetails
    {
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("contactDetails")]
        public ContactDetails ContactDetails { get; set; }
    }

    [ArchetypeDatatype("allContactDetails")]
    [JsonConverter(typeof(ArchetypeJsonConverter<AllContactDetails>))]
    public class AllContactDetails
    {
        public ContactDetails UserDetails { get; set; }
        public ContactDetails AdminDetails { get; set; }

    }

    [ArchetypeDatatype("contactDetailsList")]
    [JsonConverter(typeof(ArchetypeJsonConverter<ContactDetailsList>))]
    public class ContactDetailsList : List<ContactDetails>
    {
    }

    [ArchetypeDatatype("annualStatement")]
    [JsonConverter(typeof(ArchetypeJsonConverter<AnnualStatement>))]
    public class AnnualStatement
    {
        public DateTime FiscalYearStart { get; set; }
        public DateTime FiscalYearEnd { get; set; }
        public DateTime? DividendPaymentDate { get; set; }
        public Int32 TotalShares { get; set; }
        public Double Sales { get; set; }
        public Decimal Profit { get; set; }
    }

    [ArchetypeDatatype("mergerDetails")]
    [JsonConverter(typeof(ArchetypeJsonConverter<MergerDetails>))]
    public class MergerDetails
    {
        public DateTime MergerDate { get; set; }
        [JsonIgnore]
        public decimal MergerValue { get; set; }
    }

    #endregion

    #region complex nested model

    [ArchetypeDatatype("pages")]
    [JsonConverter(typeof(ArchetypeJsonConverter<PageDetails>))]
    public class PageDetails
    {
        [JsonProperty("pages")]
        public string Pages { get; set; }
        [JsonProperty("captions")]
        public Captions Captions { get; set; }
    }

    [ArchetypeDatatype("captions")]
    [JsonConverter(typeof(ArchetypeJsonConverter<Captions>))]
    public class Captions
    {
        [JsonProperty("captions")]
        public TextList TextStringArray { get; set; }
    }

    [ArchetypeDatatype("textstringArray")]
    [JsonConverter(typeof(ArchetypeJsonConverter<TextList>))]
    public class TextList : List<TextItem>
    {
    }

    [ArchetypeDatatype("textstringArray")]
    [JsonConverter(typeof(ArchetypeJsonConverter<TextItem>))]
    public class TextItem
    {
        [JsonProperty("textstring")]
        public string TextString { get; set; }
    }

    #endregion
}