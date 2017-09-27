using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bavarder.Enums
{
    public enum Country
    {
        Afghanistan,
        Albania,
        Algeria,
        [Description("American Samoa")]
        AmericanSamoa,
        Andorra,
        Angola,
        Anguilla,
        Antarctica,
        [Description("Antigua And Barbuda")]
        AntiguaAndBarbuda,
        Argentina,
        Armenia,
        Aruba,
        Australia,
        Austria,
        Azerbaijan,
        Bahamas,
        Bahrain,
        Bangladesh,
        Barbados,
        Belarus,
        Belgium,
        Belize,
        Benin,
        Bermuda,
        Bhutan,
        Bolivia,
        [Description("Bosnia And Herzegovina")]
        BosniaAndHerzegovina,
        Botswana,
        [Description("Bouvet Island")]
        BouvetIsland,
        Brazil,
        [Description("British Indian Ocean Territory")]
        BritishIndianOceanTerritory,
        [Description("Brunei Darussalam")]
        BruneiDarussalam, 
        Bulgaria,
        [Description("Burkina Faso")]
        BurkinaFaso,
        Burundi,
        Cambodia,
        Cameroon,
        Canada,
        [Description("Cape Verde")]
        CapeVerde,
        [Description("Cayman Islands")]
        CaymanIslands,
        [Description("Central African Republic")]
        CentralAfricanRepublic,
        Chad,
        Chile,
        China,
        [Description("Christmas Island")]
        ChristmasIsland,
        [Description("Cocos (Keeling) Islands")]
        CocosKeelingIslands,
        Colombia,
        Comoros,
        Congo,
        [Description("Congo DR")]
        CongoDR,
        [Description("Cook Islands")]
        CookIslands,
        [Description("Costa Rica")]
        CostaRica,
        [Description("Cote d'Ivoire")]
        CoteDivoire,
        Croatia,
        Cuba,
        Cyprus,
        [Description("Czech Republic")]
        CzechRepublic,
        Denmark,
        Djibouti,
        Dominica,
        [Description("Dominican Republic")]
        DominicanRepublic, 
        [Description("East Timor")]
        EastTimor,
        Ecuador,
        Egypt,
        [Description("El Salvador")]
        ElSalvador,
        [Description("Equatorial Guinea")]
        EquatorialGuinea,
        Eritrea,
        Estonia,
        Ethiopia,
        [Description("Falkand Islands (Malvinas)")]
        FalklandIslands,
        [Description("Faroe Islands")]
        FaroeIslands,
        Fiji,
        Finland,
        France,
        [Description("France Metropolitan")]
        FranceMetropolitan,
        [Description("French Guiana")]
        FrenchGuiana,
        [Description("French Polynesia")]
        FrenchPolynesia,
        [Description("French Southern Territories")]
        FrenchSouthernTerritories,
        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        Gibraltar,
        Greece,
        Greenland,
        Grenada,
        Guadeloupe,
        Guam,
        Guatemala,
        Guinea,
        [Description("Guinea-Bissau")]
        GuineaBissau,
        Guyana,
        Haiti,
        [Description("Heard and Mc Donald Islands")]
        HeardandMcDonaldIslands,
        [Description("Holy See (Vatican City State)")]
        HolySee,
        Honduras,
        [Description("Hong Kong")]
        HongKong,
        Hungary,
        Iceland,
        India,
        Indonesia,
        [Description("Iran (Islamic Republic Of)")]
        Iran,
        Iraq,
        Ireland,
        Israel,
        Italy,
        Jamaica,
        Japan,
        Jordan,
        Kazakhstan,
        Kenya,
        Kiribati,
        [Description("Korea, Democratic People's Republic of")]
        KoreaDPR,
        [Description("Korea, Republic of")]
        KoreaReublic, 
        Kuwait,
        Kyrgyzstan,
        [Description("Lao, People's Democratic Republic")]
        Lao,
        Latvia,
        Lebanon,
        Lesotho,
        Liberia,
        [Description("Libyan Arab Jamahiriya")]
        LibyanArabJamahiriya,
        Liechtenstein,
        Lithuania,
        Luxembourg,
        Macau,
        [Description("Macedonia, The Former Yugoslav Republic of")]
        Macedonia,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        [Description("Marshall Islands")]
        MarshallIslands,
        Martinique,
        Mauritania,
        Mauritius,
        Mayotte,
        Mexico,
        [Description("Micronesia, Federated States of")]
        Micronesia,
        [Description("Moldova, Republic of")]
        Moldova,
        Monaco,
        Mongolia,
        Montserrat,
        Morocco,
        Mozambique,
        Myanmar,
        Namibia,
        Nauru,
        Nepal,
        Netherlands,
        [Description("Natherlands Antilles")]
        NetherlandsAntilles,
        [Description("New Caledonia")]
        NewCaledonia,
        [Description("New Zealand")]
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        Niue,
        [Description("Norfolk Island")]
        NorfolkIsland,
        [Description("Nothern Mariana Islands")]
        NorthernMarianaIslands,
        Norway,
        Oman,
        Pakistan,
        Palau,
        Panama,
        [Description("Papau New Guinea")]
        PapuaNewGuinea,
        Paraguay,
        Peru,
        Philippines,
        Pitcairn,
        Poland,
        Portugal,
        [Description("Puerto Rico")]
        PuertoRico,
        Qatar,
        Reunion,
        Romania,
        [Description("Russian Federation")]
        RussianFederation,
        Rwanda,
        [Description("Saint Kitts and Nevis")]
        SaintKittsandNevis,
        [Description("Saint Lucia")]
        SaintLucia,
        [Description("Saint Vincent and the Grenadines")]
        SaintVincentandtheGrenadines,
        Samoa,
        [Description("San Marino")]
        SanMarino,
        [Description("Sao Tome and Principe")]
        SaoTomeandPrincipe,
        [Description("Saudi Arabia")]
        SaudiArabia, 
        Senegal, 
        Seychelles,
        [Description("Sierra Leone")]
        SierraLeone, 
        Singapore,
        [Description("Slovakia (Slovak Republic)")]
        Slovakia,
        Slovenia, 
        [Description("Solomon Islands")]
        SolomonIslands,
        Somalia,
        [Description("South Africa")]
        SouthAfrica,
        [Description("South Georgia and the South Sandwich Islands")]
        SouthGeorgiaandtheSouthSandwichIslands,
        Spain,
        [Description("Sri Lanka")]
        SriLanka, 
        [Description("St. Helena")]
        StHelena, 
        [Description("St. Pierre and Miquelon")]
        StPierreandMiquelon,
        Sudan,
        Suriname,
        [Description("Svalbard and Jan Mayen Islands")]
        SvalbardandJanMayenIslands, 
        Swaziland,
        Sweden,
        Switzerland,
        [Description("Syrian Arab Republic")]
        SyrianArabRepublic,
        [Description("Taiwan, Province of China")]
        Taiwan,
        Tajikistan,
        [Description("Tanzania, United Republic of")]
        Tanzania,
        Thailand,
        Togo,
        Tokelau,
        Tonga,
        [Description("Trinidad and Tobago")]
        TrinidadandTobago,
        Tunisia,
        Turkey,
        Turkmenistan,
        [Description("Turks and Caicos Islands")]
        TurksandCaicosIslands, 
        Tuvalu,
        Uganda,
        Ukraine,
        [Description("United Arab Emirates")]
        UnitedArabEmirates,
        [Description("United Kingdom")]
        UnitedKingdom, 
        [Description("United States")]
        UnitedStates,
        [Description("United States Minor Outlying Islands")]
        UnitedStatesMinorOutlyingIslands, 
        Uruguay,
        Uzbekistan,
        Vanuatu,
        Venezuela,
        Vietnam,
        [Description("Virgin Islands (British)")]
        VirginIslandsBritish,
        [Description("Virgin Islands (U.S.)")]
        VirginIslandsUS,
        [Description("Wallis and Futuna Islands")]
        WallisandFutunaIslands,
        [Description("Western Sahara")]
        WesternSahara, 
        Yemen,
        Yugoslavia,
        Zambia,
        Zimbabwe
    }
}