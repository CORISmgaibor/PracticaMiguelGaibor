﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMiguelGaibor
{
    public class StateInfo
    {
        public string dateFormarted { get; set; }
        public int? date { get; set; }
        public string state { get; set; }
        public int? positive { get; set; }
        public object probableCases { get; set; }
        public object negative { get; set; }
        public object pending { get; set; }
        public string totalTestResultsSource { get; set; }
        public int? totalTestResults { get; set; }
        public int? hospitalizedCurrently { get; set; }
        public int? hospitalizedCumulative { get; set; }
        public object inIcuCurrently { get; set; }
        public object inIcuCumulative { get; set; }
        public int? onVentilatorCurrently { get; set; }
        public object onVentilatorCumulative { get; set; }
        public object recovered { get; set; }
        public string lastUpdateEt { get; set; }
        public string dateModified { get; set; }
        public string checkTimeEt { get; set; }
        public int? death { get; set; }
        public int? hospitalized { get; set; }
        public object hospitalizedDischarged { get; set; }
        public string dateChecked { get; set; }
        public int? totalTestsViral { get; set; }
        public int? positiveTestsViral { get; set; }
        public int? negativeTestsViral { get; set; }
        public object positiveCasesViral { get; set; }
        public object deathConfirmed { get; set; }
        public object deathProbable { get; set; }
        public object totalTestEncountersViral { get; set; }
        public object totalTestsPeopleViral { get; set; }
        public object totalTestsAntibody { get; set; }
        public object positiveTestsAntibody { get; set; }
        public object negativeTestsAntibody { get; set; }
        public object totalTestsPeopleAntibody { get; set; }
        public object positiveTestsPeopleAntibody { get; set; }
        public object negativeTestsPeopleAntibody { get; set; }
        public object totalTestsPeopleAntigen { get; set; }
        public object positiveTestsPeopleAntigen { get; set; }
        public object totalTestsAntigen { get; set; }
        public object positiveTestsAntigen { get; set; }
        public string fips { get; set; }
        public int? positiveIncrease { get; set; }
        public int? negativeIncrease { get; set; }
        public int? total { get; set; }
        public int? totalTestResultsIncrease { get; set; }
        public int? posNeg { get; set; }
        public object dataQualityGrade { get; set; }
        public int? deathIncrease { get; set; }
        public int? hospitalizedIncrease { get; set; }
        public string hash { get; set; }
        public int? commercialScore { get; set; }
        public int? negativeRegularScore { get; set; }
        public int? negativeScore { get; set; }
        public int? positiveScore { get; set; }
        public int? score { get; set; }
        public string grade { get; set; }
    }

}
