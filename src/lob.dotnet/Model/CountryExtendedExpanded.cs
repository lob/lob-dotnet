/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)? 
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = lob.dotnet.Client.OpenAPIDateConverter;

namespace lob.dotnet.Model
{
    /// <summary>
    /// Full name of country
    /// </summary>
    /// <value>Full name of country</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CountryExtendedExpanded
    {
        /// <summary>
        /// Enum AFGHANISTAN for value: AFGHANISTAN
        /// </summary>
        [EnumMember(Value = "AFGHANISTAN")]
        AFGHANISTAN = 1,

        /// <summary>
        /// Enum ALBANIA for value: ALBANIA
        /// </summary>
        [EnumMember(Value = "ALBANIA")]
        ALBANIA = 2,

        /// <summary>
        /// Enum ALGERIA for value: ALGERIA
        /// </summary>
        [EnumMember(Value = "ALGERIA")]
        ALGERIA = 3,

        /// <summary>
        /// Enum AMERICANSAMOA for value: AMERICAN SAMOA
        /// </summary>
        [EnumMember(Value = "AMERICAN SAMOA")]
        AMERICANSAMOA = 4,

        /// <summary>
        /// Enum ANDORRA for value: ANDORRA
        /// </summary>
        [EnumMember(Value = "ANDORRA")]
        ANDORRA = 5,

        /// <summary>
        /// Enum ANGOLA for value: ANGOLA
        /// </summary>
        [EnumMember(Value = "ANGOLA")]
        ANGOLA = 6,

        /// <summary>
        /// Enum ANGUILLA for value: ANGUILLA
        /// </summary>
        [EnumMember(Value = "ANGUILLA")]
        ANGUILLA = 7,

        /// <summary>
        /// Enum ANTARCTICA for value: ANTARCTICA
        /// </summary>
        [EnumMember(Value = "ANTARCTICA")]
        ANTARCTICA = 8,

        /// <summary>
        /// Enum ANTIGUAANDBARBUDA for value: ANTIGUA AND BARBUDA
        /// </summary>
        [EnumMember(Value = "ANTIGUA AND BARBUDA")]
        ANTIGUAANDBARBUDA = 9,

        /// <summary>
        /// Enum ARGENTINA for value: ARGENTINA
        /// </summary>
        [EnumMember(Value = "ARGENTINA")]
        ARGENTINA = 10,

        /// <summary>
        /// Enum ARUBA for value: ARUBA
        /// </summary>
        [EnumMember(Value = "ARUBA")]
        ARUBA = 11,

        /// <summary>
        /// Enum AUSTRALIA for value: AUSTRALIA
        /// </summary>
        [EnumMember(Value = "AUSTRALIA")]
        AUSTRALIA = 12,

        /// <summary>
        /// Enum AUSTRIA for value: AUSTRIA
        /// </summary>
        [EnumMember(Value = "AUSTRIA")]
        AUSTRIA = 13,

        /// <summary>
        /// Enum AZERBAIJAN for value: AZERBAIJAN
        /// </summary>
        [EnumMember(Value = "AZERBAIJAN")]
        AZERBAIJAN = 14,

        /// <summary>
        /// Enum BAHRAIN for value: BAHRAIN
        /// </summary>
        [EnumMember(Value = "BAHRAIN")]
        BAHRAIN = 15,

        /// <summary>
        /// Enum BANGLADESH for value: BANGLADESH
        /// </summary>
        [EnumMember(Value = "BANGLADESH")]
        BANGLADESH = 16,

        /// <summary>
        /// Enum BARBADOS for value: BARBADOS
        /// </summary>
        [EnumMember(Value = "BARBADOS")]
        BARBADOS = 17,

        /// <summary>
        /// Enum BELARUS for value: BELARUS
        /// </summary>
        [EnumMember(Value = "BELARUS")]
        BELARUS = 18,

        /// <summary>
        /// Enum BELGIUM for value: BELGIUM
        /// </summary>
        [EnumMember(Value = "BELGIUM")]
        BELGIUM = 19,

        /// <summary>
        /// Enum BELIZE for value: BELIZE
        /// </summary>
        [EnumMember(Value = "BELIZE")]
        BELIZE = 20,

        /// <summary>
        /// Enum BENIN for value: BENIN
        /// </summary>
        [EnumMember(Value = "BENIN")]
        BENIN = 21,

        /// <summary>
        /// Enum BERMUDA for value: BERMUDA
        /// </summary>
        [EnumMember(Value = "BERMUDA")]
        BERMUDA = 22,

        /// <summary>
        /// Enum BHUTAN for value: BHUTAN
        /// </summary>
        [EnumMember(Value = "BHUTAN")]
        BHUTAN = 23,

        /// <summary>
        /// Enum BOLIVIAPLURINATIONALSTATEOF for value: BOLIVIA (PLURINATIONAL STATE OF)
        /// </summary>
        [EnumMember(Value = "BOLIVIA (PLURINATIONAL STATE OF)")]
        BOLIVIAPLURINATIONALSTATEOF = 24,

        /// <summary>
        /// Enum BONAIRESAINTEUSTATIUSANDSABA for value: BONAIRE, SAINT EUSTATIUS AND SABA
        /// </summary>
        [EnumMember(Value = "BONAIRE, SAINT EUSTATIUS AND SABA")]
        BONAIRESAINTEUSTATIUSANDSABA = 25,

        /// <summary>
        /// Enum BOSNIAANDHERZEGOVINA for value: BOSNIA AND HERZEGOVINA
        /// </summary>
        [EnumMember(Value = "BOSNIA AND HERZEGOVINA")]
        BOSNIAANDHERZEGOVINA = 26,

        /// <summary>
        /// Enum BOTSWANA for value: BOTSWANA
        /// </summary>
        [EnumMember(Value = "BOTSWANA")]
        BOTSWANA = 27,

        /// <summary>
        /// Enum BRAZIL for value: BRAZIL
        /// </summary>
        [EnumMember(Value = "BRAZIL")]
        BRAZIL = 28,

        /// <summary>
        /// Enum BRITISHINDIANOCEANTERRITORY for value: BRITISH INDIAN OCEAN TERRITORY
        /// </summary>
        [EnumMember(Value = "BRITISH INDIAN OCEAN TERRITORY")]
        BRITISHINDIANOCEANTERRITORY = 29,

        /// <summary>
        /// Enum BRITISHVIRGINISLANDS for value: BRITISH VIRGIN ISLANDS
        /// </summary>
        [EnumMember(Value = "BRITISH VIRGIN ISLANDS")]
        BRITISHVIRGINISLANDS = 30,

        /// <summary>
        /// Enum BRUNEIDARUSSALAM for value: BRUNEI DARUSSALAM
        /// </summary>
        [EnumMember(Value = "BRUNEI DARUSSALAM")]
        BRUNEIDARUSSALAM = 31,

        /// <summary>
        /// Enum BULGARIA for value: BULGARIA
        /// </summary>
        [EnumMember(Value = "BULGARIA")]
        BULGARIA = 32,

        /// <summary>
        /// Enum BURKINAFASO for value: BURKINA FASO
        /// </summary>
        [EnumMember(Value = "BURKINA FASO")]
        BURKINAFASO = 33,

        /// <summary>
        /// Enum BURUNDI for value: BURUNDI
        /// </summary>
        [EnumMember(Value = "BURUNDI")]
        BURUNDI = 34,

        /// <summary>
        /// Enum CABOVERDE for value: CABO VERDE
        /// </summary>
        [EnumMember(Value = "CABO VERDE")]
        CABOVERDE = 35,

        /// <summary>
        /// Enum CAMBODIA for value: CAMBODIA
        /// </summary>
        [EnumMember(Value = "CAMBODIA")]
        CAMBODIA = 36,

        /// <summary>
        /// Enum CAMEROON for value: CAMEROON
        /// </summary>
        [EnumMember(Value = "CAMEROON")]
        CAMEROON = 37,

        /// <summary>
        /// Enum CANADA for value: CANADA
        /// </summary>
        [EnumMember(Value = "CANADA")]
        CANADA = 38,

        /// <summary>
        /// Enum CAYMANISLANDS for value: CAYMAN ISLANDS
        /// </summary>
        [EnumMember(Value = "CAYMAN ISLANDS")]
        CAYMANISLANDS = 39,

        /// <summary>
        /// Enum CENTRALAFRICANREPUBLIC for value: CENTRAL AFRICAN REPUBLIC
        /// </summary>
        [EnumMember(Value = "CENTRAL AFRICAN REPUBLIC")]
        CENTRALAFRICANREPUBLIC = 40,

        /// <summary>
        /// Enum CHAD for value: CHAD
        /// </summary>
        [EnumMember(Value = "CHAD")]
        CHAD = 41,

        /// <summary>
        /// Enum CHILE for value: CHILE
        /// </summary>
        [EnumMember(Value = "CHILE")]
        CHILE = 42,

        /// <summary>
        /// Enum CHINA for value: CHINA
        /// </summary>
        [EnumMember(Value = "CHINA")]
        CHINA = 43,

        /// <summary>
        /// Enum COLOMBIA for value: COLOMBIA
        /// </summary>
        [EnumMember(Value = "COLOMBIA")]
        COLOMBIA = 44,

        /// <summary>
        /// Enum COMOROS for value: COMOROS
        /// </summary>
        [EnumMember(Value = "COMOROS")]
        COMOROS = 45,

        /// <summary>
        /// Enum CONGO for value: CONGO
        /// </summary>
        [EnumMember(Value = "CONGO")]
        CONGO = 46,

        /// <summary>
        /// Enum CONGODEMOCRATICREPUBLICOFTHE for value: CONGO, DEMOCRATIC REPUBLIC OF THE
        /// </summary>
        [EnumMember(Value = "CONGO, DEMOCRATIC REPUBLIC OF THE")]
        CONGODEMOCRATICREPUBLICOFTHE = 47,

        /// <summary>
        /// Enum COOKISLANDS for value: COOK ISLANDS
        /// </summary>
        [EnumMember(Value = "COOK ISLANDS")]
        COOKISLANDS = 48,

        /// <summary>
        /// Enum COSTARICA for value: COSTA RICA
        /// </summary>
        [EnumMember(Value = "COSTA RICA")]
        COSTARICA = 49,

        /// <summary>
        /// Enum CTEDIVOIRE for value: CÔTE D&#x60;IVOIRE
        /// </summary>
        [EnumMember(Value = "CÔTE D`IVOIRE")]
        CTEDIVOIRE = 50,

        /// <summary>
        /// Enum CROATIA for value: CROATIA
        /// </summary>
        [EnumMember(Value = "CROATIA")]
        CROATIA = 51,

        /// <summary>
        /// Enum CUBA for value: CUBA
        /// </summary>
        [EnumMember(Value = "CUBA")]
        CUBA = 52,

        /// <summary>
        /// Enum CURAAO for value: CURAÇAO
        /// </summary>
        [EnumMember(Value = "CURAÇAO")]
        CURAAO = 53,

        /// <summary>
        /// Enum CYPRUS for value: CYPRUS
        /// </summary>
        [EnumMember(Value = "CYPRUS")]
        CYPRUS = 54,

        /// <summary>
        /// Enum CZECHREPUBLIC for value: CZECH REPUBLIC
        /// </summary>
        [EnumMember(Value = "CZECH REPUBLIC")]
        CZECHREPUBLIC = 55,

        /// <summary>
        /// Enum DENMARK for value: DENMARK
        /// </summary>
        [EnumMember(Value = "DENMARK")]
        DENMARK = 56,

        /// <summary>
        /// Enum DJIBOUTI for value: DJIBOUTI
        /// </summary>
        [EnumMember(Value = "DJIBOUTI")]
        DJIBOUTI = 57,

        /// <summary>
        /// Enum DOMINICA for value: DOMINICA
        /// </summary>
        [EnumMember(Value = "DOMINICA")]
        DOMINICA = 58,

        /// <summary>
        /// Enum DOMINICANREPUBLIC for value: DOMINICAN REPUBLIC
        /// </summary>
        [EnumMember(Value = "DOMINICAN REPUBLIC")]
        DOMINICANREPUBLIC = 59,

        /// <summary>
        /// Enum ECUADOR for value: ECUADOR
        /// </summary>
        [EnumMember(Value = "ECUADOR")]
        ECUADOR = 60,

        /// <summary>
        /// Enum EGYPT for value: EGYPT
        /// </summary>
        [EnumMember(Value = "EGYPT")]
        EGYPT = 61,

        /// <summary>
        /// Enum ELSALVADOR for value: EL SALVADOR
        /// </summary>
        [EnumMember(Value = "EL SALVADOR")]
        ELSALVADOR = 62,

        /// <summary>
        /// Enum EQUATORIALGUINEA for value: EQUATORIAL GUINEA
        /// </summary>
        [EnumMember(Value = "EQUATORIAL GUINEA")]
        EQUATORIALGUINEA = 63,

        /// <summary>
        /// Enum ERITREA for value: ERITREA
        /// </summary>
        [EnumMember(Value = "ERITREA")]
        ERITREA = 64,

        /// <summary>
        /// Enum ESTONIA for value: ESTONIA
        /// </summary>
        [EnumMember(Value = "ESTONIA")]
        ESTONIA = 65,

        /// <summary>
        /// Enum ESWATINI for value: ESWATINI
        /// </summary>
        [EnumMember(Value = "ESWATINI")]
        ESWATINI = 66,

        /// <summary>
        /// Enum ETHIOPIA for value: ETHIOPIA
        /// </summary>
        [EnumMember(Value = "ETHIOPIA")]
        ETHIOPIA = 67,

        /// <summary>
        /// Enum FALKLANDISLANDSMALVINAS for value: FALKLAND ISLANDS (MALVINAS)
        /// </summary>
        [EnumMember(Value = "FALKLAND ISLANDS (MALVINAS)")]
        FALKLANDISLANDSMALVINAS = 68,

        /// <summary>
        /// Enum FAROEISLANDS for value: FAROE ISLANDS
        /// </summary>
        [EnumMember(Value = "FAROE ISLANDS")]
        FAROEISLANDS = 69,

        /// <summary>
        /// Enum FIJI for value: FIJI
        /// </summary>
        [EnumMember(Value = "FIJI")]
        FIJI = 70,

        /// <summary>
        /// Enum FINLAND for value: FINLAND
        /// </summary>
        [EnumMember(Value = "FINLAND")]
        FINLAND = 71,

        /// <summary>
        /// Enum FRANCE for value: FRANCE
        /// </summary>
        [EnumMember(Value = "FRANCE")]
        FRANCE = 72,

        /// <summary>
        /// Enum GABON for value: GABON
        /// </summary>
        [EnumMember(Value = "GABON")]
        GABON = 73,

        /// <summary>
        /// Enum GAMBIA for value: GAMBIA
        /// </summary>
        [EnumMember(Value = "GAMBIA")]
        GAMBIA = 74,

        /// <summary>
        /// Enum GEORGIA for value: GEORGIA
        /// </summary>
        [EnumMember(Value = "GEORGIA")]
        GEORGIA = 75,

        /// <summary>
        /// Enum GERMANY for value: GERMANY
        /// </summary>
        [EnumMember(Value = "GERMANY")]
        GERMANY = 76,

        /// <summary>
        /// Enum GHANA for value: GHANA
        /// </summary>
        [EnumMember(Value = "GHANA")]
        GHANA = 77,

        /// <summary>
        /// Enum GIBRALTAR for value: GIBRALTAR
        /// </summary>
        [EnumMember(Value = "GIBRALTAR")]
        GIBRALTAR = 78,

        /// <summary>
        /// Enum GREECE for value: GREECE
        /// </summary>
        [EnumMember(Value = "GREECE")]
        GREECE = 79,

        /// <summary>
        /// Enum GREENLAND for value: GREENLAND
        /// </summary>
        [EnumMember(Value = "GREENLAND")]
        GREENLAND = 80,

        /// <summary>
        /// Enum GRENADA for value: GRENADA
        /// </summary>
        [EnumMember(Value = "GRENADA")]
        GRENADA = 81,

        /// <summary>
        /// Enum GUATEMALA for value: GUATEMALA
        /// </summary>
        [EnumMember(Value = "GUATEMALA")]
        GUATEMALA = 82,

        /// <summary>
        /// Enum GUINEA for value: GUINEA
        /// </summary>
        [EnumMember(Value = "GUINEA")]
        GUINEA = 83,

        /// <summary>
        /// Enum GUINEABISSAU for value: GUINEA-BISSAU
        /// </summary>
        [EnumMember(Value = "GUINEA-BISSAU")]
        GUINEABISSAU = 84,

        /// <summary>
        /// Enum GUYANA for value: GUYANA
        /// </summary>
        [EnumMember(Value = "GUYANA")]
        GUYANA = 85,

        /// <summary>
        /// Enum HAITI for value: HAITI
        /// </summary>
        [EnumMember(Value = "HAITI")]
        HAITI = 86,

        /// <summary>
        /// Enum HOLYSEE for value: HOLY SEE
        /// </summary>
        [EnumMember(Value = "HOLY SEE")]
        HOLYSEE = 87,

        /// <summary>
        /// Enum HONDURAS for value: HONDURAS
        /// </summary>
        [EnumMember(Value = "HONDURAS")]
        HONDURAS = 88,

        /// <summary>
        /// Enum HONGKONG for value: HONG KONG
        /// </summary>
        [EnumMember(Value = "HONG KONG")]
        HONGKONG = 89,

        /// <summary>
        /// Enum HUNGARY for value: HUNGARY
        /// </summary>
        [EnumMember(Value = "HUNGARY")]
        HUNGARY = 90,

        /// <summary>
        /// Enum ICELAND for value: ICELAND
        /// </summary>
        [EnumMember(Value = "ICELAND")]
        ICELAND = 91,

        /// <summary>
        /// Enum INDIA for value: INDIA
        /// </summary>
        [EnumMember(Value = "INDIA")]
        INDIA = 92,

        /// <summary>
        /// Enum INDONESIA for value: INDONESIA
        /// </summary>
        [EnumMember(Value = "INDONESIA")]
        INDONESIA = 93,

        /// <summary>
        /// Enum IRANISLAMICREPUBLICOF for value: IRAN (ISLAMIC REPUBLIC OF)
        /// </summary>
        [EnumMember(Value = "IRAN (ISLAMIC REPUBLIC OF)")]
        IRANISLAMICREPUBLICOF = 94,

        /// <summary>
        /// Enum IRAQ for value: IRAQ
        /// </summary>
        [EnumMember(Value = "IRAQ")]
        IRAQ = 95,

        /// <summary>
        /// Enum IRELAND for value: IRELAND
        /// </summary>
        [EnumMember(Value = "IRELAND")]
        IRELAND = 96,

        /// <summary>
        /// Enum ISRAEL for value: ISRAEL
        /// </summary>
        [EnumMember(Value = "ISRAEL")]
        ISRAEL = 97,

        /// <summary>
        /// Enum ITALY for value: ITALY
        /// </summary>
        [EnumMember(Value = "ITALY")]
        ITALY = 98,

        /// <summary>
        /// Enum JAMAICA for value: JAMAICA
        /// </summary>
        [EnumMember(Value = "JAMAICA")]
        JAMAICA = 99,

        /// <summary>
        /// Enum JAPAN for value: JAPAN
        /// </summary>
        [EnumMember(Value = "JAPAN")]
        JAPAN = 100,

        /// <summary>
        /// Enum JORDAN for value: JORDAN
        /// </summary>
        [EnumMember(Value = "JORDAN")]
        JORDAN = 101,

        /// <summary>
        /// Enum KAZAKHSTAN for value: KAZAKHSTAN
        /// </summary>
        [EnumMember(Value = "KAZAKHSTAN")]
        KAZAKHSTAN = 102,

        /// <summary>
        /// Enum KENYA for value: KENYA
        /// </summary>
        [EnumMember(Value = "KENYA")]
        KENYA = 103,

        /// <summary>
        /// Enum KIRIBATI for value: KIRIBATI
        /// </summary>
        [EnumMember(Value = "KIRIBATI")]
        KIRIBATI = 104,

        /// <summary>
        /// Enum KOREADEMOCRATICPEOPLESREPUBLICOF for value: KOREA (DEMOCRATIC PEOPLE’S REPUBLIC OF)
        /// </summary>
        [EnumMember(Value = "KOREA (DEMOCRATIC PEOPLE’S REPUBLIC OF)")]
        KOREADEMOCRATICPEOPLESREPUBLICOF = 105,

        /// <summary>
        /// Enum KOREAREPUBLICOF for value: KOREA, REPUBLIC OF
        /// </summary>
        [EnumMember(Value = "KOREA, REPUBLIC OF")]
        KOREAREPUBLICOF = 106,

        /// <summary>
        /// Enum KUWAIT for value: KUWAIT
        /// </summary>
        [EnumMember(Value = "KUWAIT")]
        KUWAIT = 107,

        /// <summary>
        /// Enum KYRGYZSTAN for value: KYRGYZSTAN
        /// </summary>
        [EnumMember(Value = "KYRGYZSTAN")]
        KYRGYZSTAN = 108,

        /// <summary>
        /// Enum LAOPEOPLESDEMOCRATICREPUBLIC for value: LAO PEOPLE’S DEMOCRATIC REPUBLIC
        /// </summary>
        [EnumMember(Value = "LAO PEOPLE’S DEMOCRATIC REPUBLIC")]
        LAOPEOPLESDEMOCRATICREPUBLIC = 109,

        /// <summary>
        /// Enum LATVIA for value: LATVIA
        /// </summary>
        [EnumMember(Value = "LATVIA")]
        LATVIA = 110,

        /// <summary>
        /// Enum LEBANON for value: LEBANON
        /// </summary>
        [EnumMember(Value = "LEBANON")]
        LEBANON = 111,

        /// <summary>
        /// Enum LESOTHO for value: LESOTHO
        /// </summary>
        [EnumMember(Value = "LESOTHO")]
        LESOTHO = 112,

        /// <summary>
        /// Enum LIBERIA for value: LIBERIA
        /// </summary>
        [EnumMember(Value = "LIBERIA")]
        LIBERIA = 113,

        /// <summary>
        /// Enum LIBYA for value: LIBYA
        /// </summary>
        [EnumMember(Value = "LIBYA")]
        LIBYA = 114,

        /// <summary>
        /// Enum LIECHTENSTEIN for value: LIECHTENSTEIN
        /// </summary>
        [EnumMember(Value = "LIECHTENSTEIN")]
        LIECHTENSTEIN = 115,

        /// <summary>
        /// Enum LITHUANIA for value: LITHUANIA
        /// </summary>
        [EnumMember(Value = "LITHUANIA")]
        LITHUANIA = 116,

        /// <summary>
        /// Enum LUXEMBOURG for value: LUXEMBOURG
        /// </summary>
        [EnumMember(Value = "LUXEMBOURG")]
        LUXEMBOURG = 117,

        /// <summary>
        /// Enum MACAO for value: MACAO
        /// </summary>
        [EnumMember(Value = "MACAO")]
        MACAO = 118,

        /// <summary>
        /// Enum MACEDONIA for value: MACEDONIA
        /// </summary>
        [EnumMember(Value = "MACEDONIA")]
        MACEDONIA = 119,

        /// <summary>
        /// Enum MADAGASCAR for value: MADAGASCAR
        /// </summary>
        [EnumMember(Value = "MADAGASCAR")]
        MADAGASCAR = 120,

        /// <summary>
        /// Enum MALAWI for value: MALAWI
        /// </summary>
        [EnumMember(Value = "MALAWI")]
        MALAWI = 121,

        /// <summary>
        /// Enum MALAYSIA for value: MALAYSIA
        /// </summary>
        [EnumMember(Value = "MALAYSIA")]
        MALAYSIA = 122,

        /// <summary>
        /// Enum MALDIVES for value: MALDIVES
        /// </summary>
        [EnumMember(Value = "MALDIVES")]
        MALDIVES = 123,

        /// <summary>
        /// Enum MALI for value: MALI
        /// </summary>
        [EnumMember(Value = "MALI")]
        MALI = 124,

        /// <summary>
        /// Enum MALTA for value: MALTA
        /// </summary>
        [EnumMember(Value = "MALTA")]
        MALTA = 125,

        /// <summary>
        /// Enum MAURITANIA for value: MAURITANIA
        /// </summary>
        [EnumMember(Value = "MAURITANIA")]
        MAURITANIA = 126,

        /// <summary>
        /// Enum MAURITIUS for value: MAURITIUS
        /// </summary>
        [EnumMember(Value = "MAURITIUS")]
        MAURITIUS = 127,

        /// <summary>
        /// Enum MEXICO for value: MEXICO
        /// </summary>
        [EnumMember(Value = "MEXICO")]
        MEXICO = 128,

        /// <summary>
        /// Enum MOLDOVAREPUBLICOF for value: MOLDOVA, REPUBLIC OF
        /// </summary>
        [EnumMember(Value = "MOLDOVA, REPUBLIC OF")]
        MOLDOVAREPUBLICOF = 129,

        /// <summary>
        /// Enum MONACO for value: MONACO
        /// </summary>
        [EnumMember(Value = "MONACO")]
        MONACO = 130,

        /// <summary>
        /// Enum MONGOLIA for value: MONGOLIA
        /// </summary>
        [EnumMember(Value = "MONGOLIA")]
        MONGOLIA = 131,

        /// <summary>
        /// Enum MONTENEGRO for value: MONTENEGRO
        /// </summary>
        [EnumMember(Value = "MONTENEGRO")]
        MONTENEGRO = 132,

        /// <summary>
        /// Enum MONTSERRAT for value: MONTSERRAT
        /// </summary>
        [EnumMember(Value = "MONTSERRAT")]
        MONTSERRAT = 133,

        /// <summary>
        /// Enum MOROCCO for value: MOROCCO
        /// </summary>
        [EnumMember(Value = "MOROCCO")]
        MOROCCO = 134,

        /// <summary>
        /// Enum MOZAMBIQUE for value: MOZAMBIQUE
        /// </summary>
        [EnumMember(Value = "MOZAMBIQUE")]
        MOZAMBIQUE = 135,

        /// <summary>
        /// Enum MYANMAR for value: MYANMAR
        /// </summary>
        [EnumMember(Value = "MYANMAR")]
        MYANMAR = 136,

        /// <summary>
        /// Enum NAMIBIA for value: NAMIBIA
        /// </summary>
        [EnumMember(Value = "NAMIBIA")]
        NAMIBIA = 137,

        /// <summary>
        /// Enum NAURU for value: NAURU
        /// </summary>
        [EnumMember(Value = "NAURU")]
        NAURU = 138,

        /// <summary>
        /// Enum NEPAL for value: NEPAL
        /// </summary>
        [EnumMember(Value = "NEPAL")]
        NEPAL = 139,

        /// <summary>
        /// Enum NETHERLANDANTILLES for value: NETHERLAND ANTILLES
        /// </summary>
        [EnumMember(Value = "NETHERLAND ANTILLES")]
        NETHERLANDANTILLES = 140,

        /// <summary>
        /// Enum NETHERLANDS for value: NETHERLANDS
        /// </summary>
        [EnumMember(Value = "NETHERLANDS")]
        NETHERLANDS = 141,

        /// <summary>
        /// Enum NEWZEALAND for value: NEW ZEALAND
        /// </summary>
        [EnumMember(Value = "NEW ZEALAND")]
        NEWZEALAND = 142,

        /// <summary>
        /// Enum NICARAGUA for value: NICARAGUA
        /// </summary>
        [EnumMember(Value = "NICARAGUA")]
        NICARAGUA = 143,

        /// <summary>
        /// Enum NIGER for value: NIGER
        /// </summary>
        [EnumMember(Value = "NIGER")]
        NIGER = 144,

        /// <summary>
        /// Enum NIGERIA for value: NIGERIA
        /// </summary>
        [EnumMember(Value = "NIGERIA")]
        NIGERIA = 145,

        /// <summary>
        /// Enum NIUE for value: NIUE
        /// </summary>
        [EnumMember(Value = "NIUE")]
        NIUE = 146,

        /// <summary>
        /// Enum NORFOLKISLAND for value: NORFOLK ISLAND
        /// </summary>
        [EnumMember(Value = "NORFOLK ISLAND")]
        NORFOLKISLAND = 147,

        /// <summary>
        /// Enum NORWAY for value: NORWAY
        /// </summary>
        [EnumMember(Value = "NORWAY")]
        NORWAY = 148,

        /// <summary>
        /// Enum OMAN for value: OMAN
        /// </summary>
        [EnumMember(Value = "OMAN")]
        OMAN = 149,

        /// <summary>
        /// Enum PAKISTAN for value: PAKISTAN
        /// </summary>
        [EnumMember(Value = "PAKISTAN")]
        PAKISTAN = 150,

        /// <summary>
        /// Enum PANAMA for value: PANAMA
        /// </summary>
        [EnumMember(Value = "PANAMA")]
        PANAMA = 151,

        /// <summary>
        /// Enum PAPUANEWGUINEA for value: PAPUA NEW GUINEA
        /// </summary>
        [EnumMember(Value = "PAPUA NEW GUINEA")]
        PAPUANEWGUINEA = 152,

        /// <summary>
        /// Enum PARAGUAY for value: PARAGUAY
        /// </summary>
        [EnumMember(Value = "PARAGUAY")]
        PARAGUAY = 153,

        /// <summary>
        /// Enum PERU for value: PERU
        /// </summary>
        [EnumMember(Value = "PERU")]
        PERU = 154,

        /// <summary>
        /// Enum PHILIPPINES for value: PHILIPPINES
        /// </summary>
        [EnumMember(Value = "PHILIPPINES")]
        PHILIPPINES = 155,

        /// <summary>
        /// Enum PITCAIRN for value: PITCAIRN
        /// </summary>
        [EnumMember(Value = "PITCAIRN")]
        PITCAIRN = 156,

        /// <summary>
        /// Enum POLAND for value: POLAND
        /// </summary>
        [EnumMember(Value = "POLAND")]
        POLAND = 157,

        /// <summary>
        /// Enum PORTUGAL for value: PORTUGAL
        /// </summary>
        [EnumMember(Value = "PORTUGAL")]
        PORTUGAL = 158,

        /// <summary>
        /// Enum QATAR for value: QATAR
        /// </summary>
        [EnumMember(Value = "QATAR")]
        QATAR = 159,

        /// <summary>
        /// Enum ROMANIA for value: ROMANIA
        /// </summary>
        [EnumMember(Value = "ROMANIA")]
        ROMANIA = 160,

        /// <summary>
        /// Enum RUSSIANFEDERATION for value: RUSSIAN FEDERATION
        /// </summary>
        [EnumMember(Value = "RUSSIAN FEDERATION")]
        RUSSIANFEDERATION = 161,

        /// <summary>
        /// Enum RWANDA for value: RWANDA
        /// </summary>
        [EnumMember(Value = "RWANDA")]
        RWANDA = 162,

        /// <summary>
        /// Enum SAINTHELENA for value: SAINT HELENA
        /// </summary>
        [EnumMember(Value = "SAINT HELENA")]
        SAINTHELENA = 163,

        /// <summary>
        /// Enum SAINTKITTSANDNEVIS for value: SAINT KITTS AND NEVIS
        /// </summary>
        [EnumMember(Value = "SAINT KITTS AND NEVIS")]
        SAINTKITTSANDNEVIS = 164,

        /// <summary>
        /// Enum SAINTLUCIA for value: SAINT LUCIA
        /// </summary>
        [EnumMember(Value = "SAINT LUCIA")]
        SAINTLUCIA = 165,

        /// <summary>
        /// Enum SAINTVINCENTANDTHEGRENADINES for value: SAINT VINCENT AND THE GRENADINES
        /// </summary>
        [EnumMember(Value = "SAINT VINCENT AND THE GRENADINES")]
        SAINTVINCENTANDTHEGRENADINES = 166,

        /// <summary>
        /// Enum SAMOA for value: SAMOA
        /// </summary>
        [EnumMember(Value = "SAMOA")]
        SAMOA = 167,

        /// <summary>
        /// Enum SANMARINO for value: SAN MARINO
        /// </summary>
        [EnumMember(Value = "SAN MARINO")]
        SANMARINO = 168,

        /// <summary>
        /// Enum SAOTOMEANDPRINCIPE for value: SAO TOME AND PRINCIPE
        /// </summary>
        [EnumMember(Value = "SAO TOME AND PRINCIPE")]
        SAOTOMEANDPRINCIPE = 169,

        /// <summary>
        /// Enum SAUDIARABIA for value: SAUDI ARABIA
        /// </summary>
        [EnumMember(Value = "SAUDI ARABIA")]
        SAUDIARABIA = 170,

        /// <summary>
        /// Enum SENEGAL for value: SENEGAL
        /// </summary>
        [EnumMember(Value = "SENEGAL")]
        SENEGAL = 171,

        /// <summary>
        /// Enum SERBIA for value: SERBIA
        /// </summary>
        [EnumMember(Value = "SERBIA")]
        SERBIA = 172,

        /// <summary>
        /// Enum SEYCHELLES for value: SEYCHELLES
        /// </summary>
        [EnumMember(Value = "SEYCHELLES")]
        SEYCHELLES = 173,

        /// <summary>
        /// Enum SIERRALEONE for value: SIERRA LEONE
        /// </summary>
        [EnumMember(Value = "SIERRA LEONE")]
        SIERRALEONE = 174,

        /// <summary>
        /// Enum SINGAPORE for value: SINGAPORE
        /// </summary>
        [EnumMember(Value = "SINGAPORE")]
        SINGAPORE = 175,

        /// <summary>
        /// Enum SINTMAARTEN for value: SINT MAARTEN
        /// </summary>
        [EnumMember(Value = "SINT MAARTEN")]
        SINTMAARTEN = 176,

        /// <summary>
        /// Enum SLOVAKIA for value: SLOVAKIA
        /// </summary>
        [EnumMember(Value = "SLOVAKIA")]
        SLOVAKIA = 177,

        /// <summary>
        /// Enum SLOVENIA for value: SLOVENIA
        /// </summary>
        [EnumMember(Value = "SLOVENIA")]
        SLOVENIA = 178,

        /// <summary>
        /// Enum SOLOMONISLANDS for value: SOLOMON ISLANDS
        /// </summary>
        [EnumMember(Value = "SOLOMON ISLANDS")]
        SOLOMONISLANDS = 179,

        /// <summary>
        /// Enum SOMALIA for value: SOMALIA
        /// </summary>
        [EnumMember(Value = "SOMALIA")]
        SOMALIA = 180,

        /// <summary>
        /// Enum SOUTHAFRICA for value: SOUTH AFRICA
        /// </summary>
        [EnumMember(Value = "SOUTH AFRICA")]
        SOUTHAFRICA = 181,

        /// <summary>
        /// Enum SOUTHGEORGIAANDTHESOUTHSANDWICHISLANDS for value: SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS
        /// </summary>
        [EnumMember(Value = "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS")]
        SOUTHGEORGIAANDTHESOUTHSANDWICHISLANDS = 182,

        /// <summary>
        /// Enum SOUTHSUDAN for value: SOUTH SUDAN
        /// </summary>
        [EnumMember(Value = "SOUTH SUDAN")]
        SOUTHSUDAN = 183,

        /// <summary>
        /// Enum SPAIN for value: SPAIN
        /// </summary>
        [EnumMember(Value = "SPAIN")]
        SPAIN = 184,

        /// <summary>
        /// Enum SRILANKA for value: SRI LANKA
        /// </summary>
        [EnumMember(Value = "SRI LANKA")]
        SRILANKA = 185,

        /// <summary>
        /// Enum SUDAN for value: SUDAN
        /// </summary>
        [EnumMember(Value = "SUDAN")]
        SUDAN = 186,

        /// <summary>
        /// Enum SURINAME for value: SURINAME
        /// </summary>
        [EnumMember(Value = "SURINAME")]
        SURINAME = 187,

        /// <summary>
        /// Enum SWEDEN for value: SWEDEN
        /// </summary>
        [EnumMember(Value = "SWEDEN")]
        SWEDEN = 188,

        /// <summary>
        /// Enum SWITZERLAND for value: SWITZERLAND
        /// </summary>
        [EnumMember(Value = "SWITZERLAND")]
        SWITZERLAND = 189,

        /// <summary>
        /// Enum SYRIANARABREPUBLIC for value: SYRIAN ARAB REPUBLIC
        /// </summary>
        [EnumMember(Value = "SYRIAN ARAB REPUBLIC")]
        SYRIANARABREPUBLIC = 190,

        /// <summary>
        /// Enum TAIWAN for value: TAIWAN
        /// </summary>
        [EnumMember(Value = "TAIWAN")]
        TAIWAN = 191,

        /// <summary>
        /// Enum TAJIKISTAN for value: TAJIKISTAN
        /// </summary>
        [EnumMember(Value = "TAJIKISTAN")]
        TAJIKISTAN = 192,

        /// <summary>
        /// Enum TANZANIA for value: TANZANIA
        /// </summary>
        [EnumMember(Value = "TANZANIA")]
        TANZANIA = 193,

        /// <summary>
        /// Enum THAILAND for value: THAILAND
        /// </summary>
        [EnumMember(Value = "THAILAND")]
        THAILAND = 194,

        /// <summary>
        /// Enum THEBAHAMAS for value: THE BAHAMAS
        /// </summary>
        [EnumMember(Value = "THE BAHAMAS")]
        THEBAHAMAS = 195,

        /// <summary>
        /// Enum TIMORLESTE for value: TIMOR-LESTE
        /// </summary>
        [EnumMember(Value = "TIMOR-LESTE")]
        TIMORLESTE = 196,

        /// <summary>
        /// Enum TOGO for value: TOGO
        /// </summary>
        [EnumMember(Value = "TOGO")]
        TOGO = 197,

        /// <summary>
        /// Enum TOKELAU for value: TOKELAU
        /// </summary>
        [EnumMember(Value = "TOKELAU")]
        TOKELAU = 198,

        /// <summary>
        /// Enum TONGA for value: TONGA
        /// </summary>
        [EnumMember(Value = "TONGA")]
        TONGA = 199,

        /// <summary>
        /// Enum TRINIDADANDTOBAGO for value: TRINIDAD AND TOBAGO
        /// </summary>
        [EnumMember(Value = "TRINIDAD AND TOBAGO")]
        TRINIDADANDTOBAGO = 200,

        /// <summary>
        /// Enum TUNISIA for value: TUNISIA
        /// </summary>
        [EnumMember(Value = "TUNISIA")]
        TUNISIA = 201,

        /// <summary>
        /// Enum TURKEY for value: TURKEY
        /// </summary>
        [EnumMember(Value = "TURKEY")]
        TURKEY = 202,

        /// <summary>
        /// Enum TURKMENISTAN for value: TURKMENISTAN
        /// </summary>
        [EnumMember(Value = "TURKMENISTAN")]
        TURKMENISTAN = 203,

        /// <summary>
        /// Enum TURKSANDCAICOSISLANDS for value: TURKS AND CAICOS ISLANDS
        /// </summary>
        [EnumMember(Value = "TURKS AND CAICOS ISLANDS")]
        TURKSANDCAICOSISLANDS = 204,

        /// <summary>
        /// Enum TUVALU for value: TUVALU
        /// </summary>
        [EnumMember(Value = "TUVALU")]
        TUVALU = 205,

        /// <summary>
        /// Enum UGANDA for value: UGANDA
        /// </summary>
        [EnumMember(Value = "UGANDA")]
        UGANDA = 206,

        /// <summary>
        /// Enum UKRAINE for value: UKRAINE
        /// </summary>
        [EnumMember(Value = "UKRAINE")]
        UKRAINE = 207,

        /// <summary>
        /// Enum UNITEDARABEMIRATES for value: UNITED ARAB EMIRATES
        /// </summary>
        [EnumMember(Value = "UNITED ARAB EMIRATES")]
        UNITEDARABEMIRATES = 208,

        /// <summary>
        /// Enum UNITEDKINGDOM for value: UNITED KINGDOM
        /// </summary>
        [EnumMember(Value = "UNITED KINGDOM")]
        UNITEDKINGDOM = 209,

        /// <summary>
        /// Enum UNITEDSTATES for value: UNITED STATES
        /// </summary>
        [EnumMember(Value = "UNITED STATES")]
        UNITEDSTATES = 210,

        /// <summary>
        /// Enum URUGUAY for value: URUGUAY
        /// </summary>
        [EnumMember(Value = "URUGUAY")]
        URUGUAY = 211,

        /// <summary>
        /// Enum UZBEKISTAN for value: UZBEKISTAN
        /// </summary>
        [EnumMember(Value = "UZBEKISTAN")]
        UZBEKISTAN = 212,

        /// <summary>
        /// Enum VANUATU for value: VANUATU
        /// </summary>
        [EnumMember(Value = "VANUATU")]
        VANUATU = 213,

        /// <summary>
        /// Enum VENEZUELA for value: VENEZUELA
        /// </summary>
        [EnumMember(Value = "VENEZUELA")]
        VENEZUELA = 214,

        /// <summary>
        /// Enum VIETNAM for value: VIET NAM
        /// </summary>
        [EnumMember(Value = "VIET NAM")]
        VIETNAM = 215,

        /// <summary>
        /// Enum WESTERNSAHARA for value: WESTERN SAHARA
        /// </summary>
        [EnumMember(Value = "WESTERN SAHARA")]
        WESTERNSAHARA = 216,

        /// <summary>
        /// Enum YEMEN for value: YEMEN
        /// </summary>
        [EnumMember(Value = "YEMEN")]
        YEMEN = 217,

        /// <summary>
        /// Enum ZAMBIA for value: ZAMBIA
        /// </summary>
        [EnumMember(Value = "ZAMBIA")]
        ZAMBIA = 218,

        /// <summary>
        /// Enum ZIMBABWE for value: ZIMBABWE
        /// </summary>
        [EnumMember(Value = "ZIMBABWE")]
        ZIMBABWE = 219

    }

}