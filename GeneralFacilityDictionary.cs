using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawingConsolidationProject
{
    class GeneralFacilityDictionary
    {
        public static string GetDestination(Drawing drawingId)
        {

            var destinations = new Dictionary<generalfacilitydestinationpath, string>();

            //#region Test
            //destinations.Add(new generalfacilitydestinationpath("005", "441", "A"), @"C:\Users\abshier_c\Documents\TestDest\A\005-441-A");
            //destinations.Add(new generalfacilitydestinationpath("005", "444", "B"), @"C:\Users\abshier_c\Documents\TestDest\B\005-444-B");
            //destinations.Add(new generalfacilitydestinationpath("005", "441", "C"), @"C:\Users\abshier_c\Documents\TestDest\C\005-441-C");
            //destinations.Add(new generalfacilitydestinationpath("005", "444", "D"), @"C:\Users\abshier_c\Documents\TestDest\D\005-444-D");
            //destinations.Add(new generalfacilitydestinationpath("005", "441", "a"), @"C:\Users\abshier_c\Documents\TestDest\A\005-441-A");
            //destinations.Add(new generalfacilitydestinationpath("005", "444", "b"), @"C:\Users\abshier_c\Documents\TestDest\B\005-444-B");
            //destinations.Add(new generalfacilitydestinationpath("005", "441", "c"), @"C:\Users\abshier_c\Documents\TestDest\C\005-441-C");
            //destinations.Add(new generalfacilitydestinationpath("005", "444", "d"), @"C:\Users\abshier_c\Documents\TestDest\D\005-444-D");
            //#endregion

            #region 005-XXX-A-General Facility
            destinations.Add(new generalfacilitydestinationpath("005", "000", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-000-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "002", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-002-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "004", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-004-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "009", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-009-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "014", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-014-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "038", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-038-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "042", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-042-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "043", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-043-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "044", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-044-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "045", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-045-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "059", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-059-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "061", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-061-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "063", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-063-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "062", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-062-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "068", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-068-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "069", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-069-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "076", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-076-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "079", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-079-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "080", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-080-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "081", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-081-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "082", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-082-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "083", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-083-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "084", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-084-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "085", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-085-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "086", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-086-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "088", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-088-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "090", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-090-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "091", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-091-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "093", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-093-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "094", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-094-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "095", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-095-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "097", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-097-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "098", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-098-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "099", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-099-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "103", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-103-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "107", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-107-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "109", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-109-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "112", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-112-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "113", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-113-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "119", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-119-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "120", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-120-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "122", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-122-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "125", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-125-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "126", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-126-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "128", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-128-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "130", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-130-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "131", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-131-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "141", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-141-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "142", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-142-A-\");
            destinations.Add(new generalfacilitydestinationpath("005", "143", "A"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\A_Sheets\005-143-A-\");
            #endregion
            #region 005-XXX-C-General Facility
            destinations.Add(new generalfacilitydestinationpath("005", "000", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-000-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "002", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-002-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "009", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-009-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "042", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-042-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "045", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-045-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "052", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-052-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "059", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-059-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "061", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-061-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "063", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-063-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "068", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-068-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "069", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-069-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "076", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-076-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "078", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-078-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "079", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-079-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "081", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-081-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "083", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-083-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "085", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-085-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "088", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-088-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "090", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-090-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "091", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-091-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "094", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-094-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "095", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-095-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "096", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-096-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "099", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-099-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "103", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-103-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "107", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-107-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "112", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-112-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "113", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-113-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "119", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-119-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "120", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-120-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "142", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-142-C-\");
            destinations.Add(new generalfacilitydestinationpath("005", "143", "C"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\C_Sheets\005-143-C-\");
            #endregion            
            #region 005-XXX-D-General Facility
            destinations.Add(new generalfacilitydestinationpath("005", "000", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-000-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "002", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-002-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "038", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-038-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "044", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-044-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "045", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-045-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "051", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-051-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "059", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-059-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "061", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-061-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "063", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-063-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "062", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-062-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "068", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-068-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "069", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-069-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "079", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-079-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "081", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-081-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "083", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-083-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "084", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-084-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "085", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-085-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "086", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-086-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "088", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-088-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "090", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-090-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "091", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-091-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "093", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-093-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "094", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-094-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "095", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-095-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "098", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-098-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "099", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-099-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "101", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-101-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "103", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-103-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "107", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-107-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "112", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-112-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "113", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-113-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "115", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-115-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "118", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-118-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "132", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-132-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "134", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-134-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "135", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-135-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "138", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-138-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "141", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-141-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "142", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-142-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "143", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-143-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "144", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-144-D-\");
            destinations.Add(new generalfacilitydestinationpath("005", "145", "D"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\D_Sheets\005-145-D-\");
            #endregion
            #region 005-XXX-E-General Facility
            destinations.Add(new generalfacilitydestinationpath("005", "000", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-000-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "002", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-002-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "045", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-045-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "059", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-059-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "061", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-061-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "063", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-063-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "062", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-062-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "069", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-069-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "071", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-071-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "076", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-076-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "079", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-079-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "081", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-081-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "083", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-083-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "084", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-084-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "085", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-085-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "088", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-088-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "090", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-090-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "094", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-094-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "107", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-107-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "112", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-112-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "114", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-114-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "132", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-132-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "133", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-133-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "134", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-134-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "140", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-140-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "141", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-141-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "142", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-142-E-\");
            destinations.Add(new generalfacilitydestinationpath("005", "143", "E"), @"\\sscowbfs03\public\toms\cadd\Rendition\1 - Pipeline Drawings\E_Sheets\005-143-E-\");
            #endregion


            var type = drawingId.drawingType;
            var location = drawingId.drawingLocation;
            var size = drawingId.drawingSize;

            var founditem = destinations.FirstOrDefault(x => x.Key.type == type && x.Key.location == location && x.Key.size == size);

            return founditem.Value;
        }

        public class generalfacilitydestinationpath
        {
            public generalfacilitydestinationpath(string location, string type, string size)
            {
                this.location = location;
                this.type = type;
                this.size = size;
            }
            public string location { get; set; }
            public string type { get; set; }
            public string size { get; set; }

        }
    }
}
