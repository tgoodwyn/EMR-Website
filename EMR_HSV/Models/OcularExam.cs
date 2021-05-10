using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Models
{
    public class OcularExam
    {
        public int id { get; set; }
        //Posterior Segment

        // now a string, maybe do same for rest
        public string Vitreous { get; set; }
        public string Macula { get; set; }
        public string Vasculature { get; set; }
        public string PosteriorPole { get; set; }
        public string PeripheralRetina { get; set; }
        public string MiscRetina { get; set; }
        public string DiabeticEval { get; set; }
        public string HTNEval { get; set; }
        public string ARMD { get; set; }
        public string custom1 { get; set; }
        public string custom2 { get; set; }
        public string custom3 { get; set; }

        //Ophthalmic Indicators
        public string SpontaneousVenousPulsationOD { get; set; }
        public string SpontaneousVenousPulsationOS { get; set; }
        public string FovealReflexOD { get; set; }
        public string FovealReflexOS { get; set; }

        //Fundus Eval
        public string[] fundusMethods = {"Not Performed", "Small Pupil BIO", "Dilated Eval", "Undilated Eval", "Optomap Imaging", "DFE with Optomap"};
        public int FundusMethod { get; set; }
        public string FundusDilation { get; set; }
        public string DilatingAgent { get; set; }

        public bool FundusEvaluation78D { get; set; }
        public bool FundusEvaluation90D { get; set; }
        public bool FundusEvaluation20D { get; set; }
        public bool FundusEvaluationPR { get; set; }
        public bool FundusEvaluationScleral { get; set; }
        public bool FundusEvaluationDirect { get; set; }
        public bool FundusEvaluationOther { get; set; }
        public string FundusEvaluationOtherString { get; set; }

        public bool FundusNotesAdvised { get; set; }
        public bool FundusNotesRescheduled { get; set; }
        public bool FundusNotesDeclined { get; set; }
        public bool FundusNotesPerformed { get; set; }
        public bool FundusNotesRefused { get; set; }
        public bool FundusNotesNotIndicated { get; set; }
        public bool FundusNotesContraindicated { get; set; }
        public bool FundusNotesRecent { get; set; }

        //Cup/Disc
        public float ODSliderHorizontal { get; set; }
        public float OSSliderHorizontal { get; set; }
        public float ODSliderVertical { get; set; }
        public float OSSliderVertical { get; set; }

        //Optic Nerve Head Assessment
        public string OpticNerve { get; set; }
        public string NerveFiberLayer { get; set; }

        public bool DeepLaminaOD { get; set; }
        public bool ShallowOD { get; set; }
        public bool RoundOD { get; set; }
        public bool OvalOD { get; set; }
        public bool TempSlopingOD { get; set; }
        public bool UnderminingOD { get; set; }
        public bool PeripapAtrophyOD { get; set; }
        public bool ScleralCresentOD { get; set; }
        public bool PigmentCresentOD { get; set; }
        public bool OpticPitOD { get; set; }
        public bool MuyelinationOD { get; set; }
        public bool GlialRemnantsOD { get; set; }
        public bool DeepLaminaOS { get; set; }
        public bool ShallowOS { get; set; }
        public bool RoundOS { get; set; }
        public bool OvalOS { get; set; }
        public bool TempSlopingOS { get; set; }
        public bool UnderminingOS { get; set; }
        public bool PeripapAtrophyOS { get; set; }
        public bool ScleralCresentOS { get; set; }
        public bool PigmentCresentOS { get; set; }
        public bool OpticPitOS { get; set; }
        public bool MuyelinationOS { get; set; }
        public bool GlialRemnantsOS { get; set; }

        public Appointment Appointment { get; set; }
        public int AppointmentID { get; set; }
    }
}
