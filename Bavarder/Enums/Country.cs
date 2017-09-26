using System;
using System.Collections.Generic;
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
        [Display(Name = "American Samoa")]
        AmericanSamoa,
        Andorra,
        Angola,
        Anguilla,
        Antarctica,
        [Display(Name = "Antigua And Barbuda")]
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
        [Display(Name = "Bosnia And Herzegovina")]
        BosniaAndHerzegovina,
        Botswana,
        [Display(Name = "Bouvet Island")]
        BouvetIsland,
        Brazil,
        [Display(Name = "British Indian Ocean Territory")]
        BritishIndianOceanTerritory,
        [Display(Name = "Brunei Darussalam")]
        BruneiDarussalam, 
        Bulgaria,
        [Display(Name = "Burkina Faso")]
        BurkinaFaso,
        Burundi,
        Cambodia,
        Cameroon,
        Canada,
        [Display(Name = "Cape Verde")]
        CapeVerde,
        [Display(Name = "Cayman Islands")]
        CaymanIslands,
        [Display(Name = "Central African Republic")]
        CentralAfricanRepublic,
        Chad,
        Chile,
        China,
        [Display(Name = "Christmas Island")]
        ChristmasIsland,
        [Display(Name = "Cocos (Keeling) Islands")]
        CocosKeelingIslands,
        Colombia,
        Comoros,
        Congo,
        [Display(Name = "Congo DR")]
        CongoDR,
        [Display(Name = "Cook Islands")]
        CookIslands,
        [Display(Name = "Costa Rica")]
        CostaRica,
        [Display(Name = "Cote d'Ivoire")]
        CoteDivoire,
        Croatia,
        Cuba,
        Cyprus,
        [Display(Name = "Czech Republic")]
        CzechRepublic,
        Denmark,
        Djibouti,
        Dominica,
        [Display(Name = "Dominican Republic")]
        DominicanRepublic, 
        [Display(Name = "East Timor")]
        EastTimor,
        Ecuador,
        Egypt,
        [Display(Name = "El Salvador")]
        ElSalvador,
        [Display(Name = "Equatorial Guinea")]
        EquatorialGuinea,
        Eritrea,
        Estonia,
        Ethiopia,
        [Display(Name = "Falkand Islands (Malvinas)")]
        FalklandIslands,
        [Display(Name = "Faroe Islands")]
        FaroeIslands,
        Fiji,
        Finland,
        France,
        [Display(Name = "France Metropolitan")]
        FranceMetropolitan,
        [Display(Name = "French Guiana")]
        FrenchGuiana,
        [Display(Name = "French Polynesia")]
        FrenchPolynesia,
        [Display(Name = "French Southern Territories")]
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
        [Display(Name = "Guinea-Bissau")]
        GuineaBissau,
        Guyana,
        Haiti,
        [Display(Name = "Heard and Mc Donald Islands")]
        HeardandMcDonaldIslands,
        [Display(Name = "Holy See (Vatican City State)")]
        HolySee,
        Honduras,
        [Display(Name = "Hong Kong")]
        HongKong,
        Hungary,
        Iceland,
        India,
        Indonesia,
        [Display(Name = "Iran (Islamic Republic Of)")]
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
        [Display(Name = "Korea, Democratic People's Republic of")]
        KoreaDPR,
        [Display(Name = "Korea, Republic of")]
        KoreaReublic, 
        Kuwait,
        Kyrgyzstan,
        [Display(Name = "Lao, People's Democratic Republic")]
        Lao,
        Latvia,
        Lebanon,
        Lesotho,
        Liberia,
        [Display(Name = "Libyan Arab Jamahiriya")]
        LibyanArabJamahiriya,
        Liechtenstein,
        Lithuania,
        Luxembourg,
        Macau,
        [Display(Name = "Macedonia, The Former Yugoslav Republic of")]
        Macedonia,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        [Display(Name = "Marshall Islands")]
        MarshallIslands,
        Martinique,
        Mauritania,
        Mauritius,
        Mayotte,
        Mexico,
        [Display(Name = "Micronesia, Federated States of")]
        Micronesia,
        [Display(Name = "Moldova, Republic of")]
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
        [Display(Name = "Natherlands Antilles")]
        NetherlandsAntilles,
        [Display(Name = "New Caledonia")]
        NewCaledonia,
        [Display(Name = "New Zealand")]
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        Niue,
        [Display(Name = "Norfolk Island")]
        NorfolkIsland,
        [Display(Name = "Nothern Mariana Islands")]
        NorthernMarianaIslands,
        Norway,
        Oman,
        Pakistan,
        Palau,
        Panama,
        [Display(Name = "Papau New Guinea")]
        PapuaNewGuinea,
        Paraguay,
        Peru,
        Philippines,
        Pitcairn,
        Poland,
        Portugal,
        [Display(Name = "Puerto Rico")]
        PuertoRico,
        Qatar,
        Reunion,
        Romania,
        [Display(Name = "Russian Federation")]
        RussianFederation,
        Rwanda,
        [Display(Name = "Saint Kitts and Nevis")]
        SaintKittsandNevis,
        [Display(Name = "Saint Lucia")]
        SaintLucia,
        [Display(Name = "Saint Vincent and the Grenadines")]
        SaintVincentandtheGrenadines,
        Samoa,
        [Display(Name = "San Marino")]
        SanMarino,
        [Display(Name = "Sao Tome and Principe")]
        SaoTomeandPrincipe,
        [Display(Name = "Saudi Arabia")]
        SaudiArabia, 
        Senegal, 
        Seychelles,
        [Display(Name = "Sierra Leone")]
        SierraLeone, 
        Singapore,
        [Display(Name = "Slovakia (Slovak Republic)")]
        Slovakia,
        Slovenia, 
        [Display(Name = "Solomon Islands")]
        SolomonIslands,
        Somalia,
        [Display(Name = "South Africa")]
        SouthAfrica,
        [Display(Name = "South Georgia and the South Sandwich Islands")]
        SouthGeorgiaandtheSouthSandwichIslands,
        Spain,
        [Display(Name = "Sri Lanka")]
        SriLanka, 
        [Display(Name = "St. Helena")]
        StHelena, 
        [Display(Name = "St. Pierre and Miquelon")]
        StPierreandMiquelon,
        Sudan,
        Suriname,
        [Display(Name = "Svalbard and Jan Mayen Islands")]
        SvalbardandJanMayenIslands, 
        Swaziland,
        Sweden,
        Switzerland,
        [Display(Name = "Syrian Arab Republic")]
        SyrianArabRepublic,
        [Display(Name = "Taiwan, Province of China")]
        Taiwan,
        Tajikistan,
        [Display(Name = "Tanzania, United Republic of")]
        Tanzania,
        Thailand,
        Togo,
        Tokelau,
        Tonga,
        [Display(Name = "Trinidad and Tobago")]
        TrinidadandTobago,
        Tunisia,
        Turkey,
        Turkmenistan,
        [Display(Name = "Turks and Caicos Islands")]
        TurksandCaicosIslands, 
        Tuvalu,
        Uganda,
        Ukraine,
        [Display(Name = "United Arab Emirates")]
        UnitedArabEmirates,
        [Display(Name = "United Kingdom")]
        UnitedKingdom, 
        [Display(Name = "United States")]
        UnitedStates,
        [Display(Name = "United States Minor Outlying Islands")]
        UnitedStatesMinorOutlyingIslands, 
        Uruguay,
        Uzbekistan,
        Vanuatu,
        Venezuela,
        Vietnam,
        [Display(Name = "Virgin Islands (British)")]
        VirginIslandsBritish,
        [Display(Name = "Virgin Islands (U.S.)")]
        VirginIslandsUS,
        [Display(Name = "Wallis and Futuna Islands")]
        WallisandFutunaIslands,
        [Display(Name = "Western Sahara")]
        WesternSahara, 
        Yemen,
        Yugoslavia,
        Zambia,
        Zimbabwe
    }
}