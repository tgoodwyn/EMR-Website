/* =====================================================================
    * GUI => C# Translation Table
    * ---------------------------------------------------------------------
    *         GUI Element             => C# data type
    * ---------------------------------------------------------------------
    * Labels + Dropdown for each      => string array for options + 1 int for each label 
    * Dropdown (single label)         => string array for options + 1 int for selection
    * Radio button (options labeled)  => string array for options + 1 int for selection
    * Radio button (set labeled)      => string array for options + 1 int for each set 
    * Checkboxes (set labeled)        => string array for options + List<int> for each set
    * Slider                          => float
    * ======================================================================
    * 
    * 
    * 
    * NOTE on [Display(Name = "")]
    * The string array we use to hold options does not represent something that will actually be visible
    * in the GUI. The property that holds the selection from the options 
    * (represented as an index to the string array) will, however, have a [Display(Name = "")] attribute
    * 
    * 
         
*/




// ==========================================================================
// start of Keyara assignment for 02/26 weekend
// make properties for everything inside a /* */ section
// 
// + 8 string arrays
// + 19 ints
// + 3 List<int>
// + 4 floats
// ------------------
//   34 properties total
// 
//  The string arrays WILL be initialized.
//      Everything else will not.
//  The string arrays WILL NOT have Display, Range attributes
//      Everything else will
// ==========================================================================

// example of how most sections work
string[] colors = { "red", "green", "blue", "none" };

[Range(0, 3)]
[Display(Name = "Primary Color")]
int chosenColor;
// delete example when done


// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// Posterior Segment
// 9x Label + Dropdown
// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


/* 
    1 string array, 5 elements ("NORM", "LOW", etc.), 
    - display name: n/a
    - property name: "conditions" 

    9 ints
    - display names: see pic  (vitreous, mascula, etc.)
    - range(0,4): bc these are indices to the string array
    - property names: abbreviated form of display name 
*/


// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// Ophthalmic Indicators
// 4x Radio button (set labeled)
// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/*
    * Label + Dropdown
    * 
    1 string array, 3 elements ("PLUS", "MINUS", "UNCHECKED"), 
    - display name: n/a
    - property name: "indications" 

    4 ints
    - property names: od,os + SVP,FR (e.g. odFR)
    - display names: unabbreviated version of property name (e.g. "OD Foveal Reflex")
    - range(0,2)
  
*/



// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// Fundus Evaluation Method
// 3x Radio button (options labeled)
// 1 Dropdown (single label)
// 1 set of Checkboxes
// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/*
    1st set of radio buttons - immediately underneath "Fundus Evaluation Method" in the picture
    1 string array:
    - display name: n/a
    - property name: "dilationTechniqueOptions" 
    - 6 elements: the 6 options  listed there
            
    1 int:
    - display name: "Fundus Evaluation Method"
    - property name: "chosenTechnique" or something
    - range(0,5)
*/

/*
    2nd set of radio buttons (they look like checkboxes but actually should be radio buttons)
    1 string array:
    - display name: n/a
    - property name: "dilationQuantityOptions"
    - 2 elements: ("1gtt", "2gtt")
            
    1 int:
    - display name: "Dilated with""
    - property name: "chosenDilationQuantity" 
    - range(0,1)
*/

/*
    3rd set of radio buttons (also checkboxes that should be radio buttons)
    - note: not including the dropdown menu for "other" for the time being
    1 string array:
    - display name: n/a
    - property name: "evaluationToolOptions"
    - 6 elements: ("78D lense", "90D lens", etc)
            
    1 int:
    - display name: "Evaluated with"
    - property name: "chosenEvaluationTool" 
    - range(0,5)
*/

/*
    *  Dropdown menu ("tropicamide")
    1 string array:
    - display name: n/a
    - property name: "dilationAgentOptions"
    - 1 elements: ("tropicamide") - probably more will be added in future
            
    1 int:
    - display name: "Dilation Agent""
    - property name: "chosenDilationAgent" 
    - range(0,n)

*/

/*  Checkboxes ("notes")
    1 string array:
    - display name: n/a
    - property name: "notesOptions"
    - 8 elements: ones listed in picture

    1 List<int>:
    - display name: "Notes"
    - property name: "chosenNotes" 
    - needs to be a list since the size is variable

*/



// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// Cup/Disc Ratio Tool
// 4x Sliders
// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/*
    4 floats
    - property names: cpdr + (OD,OS + H,V) (e.g. cpdrODH, cpdrODV, etc.)
    - display names: unabbreviated version of property name (e.g. "Cup/Disc Ratio OD Horizontal,
    - Cup/Disc Ratio OD Vertical")
    - range(0,1.0)
  
*/


// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// Optic Nerve Head Assessment
// 2x Labels + Dropdown for each
// 2x Checkboxes (set labeled) 
// (it may seem like 4 set, but its really 2 sets split over 2 columns)
// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// Note: Rim notching and thinning are the only things in the picture not 
// mentioned in our instructions, so they've been left out for now
// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/*  Label + Dropdown
    1 string array, 5 elements ("NORM", "LOW", etc.), 
    - NO NEED TO RECREATE THIS, SAME ARRAY AS FOR POSTERIOR SEGMENT

    2 ints
    - display names: Optic nerve, Nerve Fiber Layer (see pic)
    - property names: abbreviated form of display names 
    - range(0,4): 
  
*/

/*  Checkboxes ("Optic Nerve Description")
    1 string array:
    - display name: n/a
    - property name: "ond choices"
    - 12 elements: ones listed in picture (it may 

    2 List<int>:
    - display name: "OD", "OS" + "Optic Nerve Description"
    - property name: abbreviated form (e.g. odOND, os OND)
    
*/

--------------------------------------------------------------------------------------------


<div>
    <a asp-page="Index">Back to List</a>
</div>
<br />

<form method="post">

    <!--Posterior Segment-->
    <div>
        <label>POSTERIOR SEGMENT</label>
        @foreach (var region in EMR_HSV.Models.OcularExam.posteriorSegmentRegions)
        {
            <br />
            <label for="segmentResults">@region</label>
            <br />
            @foreach (var result in EMR_HSV.Models.OcularExam.posteriorSegmentResults)
            {
                <input type="radio" id="segmentResults" name="OcularExam.segmentResults" value="@result" /> @result<br />
            }
        }
    </div>

    <!--OPHTHALMIC INDICATORS-->
    <div>
        <br />
        <label>OPHTHALMIC INDICATORS</label>
        @foreach (var indicator in EMR_HSV.Models.OcularExam.ophthalmicIndicators)
        {
            <br />
            <label for="opthalmicIndicators">@indicator</label>
            <br />
            @foreach (var option in EMR_HSV.Models.OcularExam.optionsODOS)
            {
                <label>@option</label>
                <br />
                @foreach (var result in EMR_HSV.Models.OcularExam.ophthalmicResults)
                {
                    <input type="radio" id="ophthalmicIndicators" name="OcularExam.ophthalmicResults" value="@result" /> @result<br />;
                }
            }
        }
    </div>

    <!--FUNDUS EVALUATION METHOD-->
    <div>
        <br />
        <label>FUNDUS EVALUATION METHOD</label>
        <br />
        @foreach (var option in EMR_HSV.Models.OcularExam.fundusOptions)
        {
            <input type="radio" id="fundusOptions" name="OcularExam.fundusResults" value="@option" /> @option<br />;
        }

        <br />
        <label>Dilated With:</label>
        <br />
        @foreach (var dilation in EMR_HSV.Models.OcularExam.fundusDilations)
        {
            <input type="radio" id="fundusDilations" name="OcularExam.fundusDilations" value="@dilation" /> @dilation<br />;
        }

        <!-- Evaluation section requires textbox-->
        <br />
        <label>Evaluated With:</label>
        <br />
        @foreach (var evaluation in EMR_HSV.Models.OcularExam.fundusEvaluations)
        {
            <input type="checkbox" id="fundusEvaluations" name="OcularExam.fundusEvaluations" value="@evaluation" /> @evaluation<br />;
        }

        <br />
        <label>Notes:</label>
        <br />
        @foreach (var note in EMR_HSV.Models.OcularExam.fundusNotes)
        {
            <input type="checkbox" id="fundusNotes" name="OcularExam.fundusNotes" value="@note" /> @note<br />;
        }
    </div>

    <!--OPTIC NERVE DESCRIPTORS-->
    <div>
        <br />
        <label>OPTIC NERVE DESCRIPTORS</label>
        <br />
        @foreach (var descriptor in EMR_HSV.Models.OcularExam.opticNerveDescriptors)
        {
            <br />
            <label for="opticNerveDescriptors">@descriptor</label>
            <br />
            @foreach (var option in EMR_HSV.Models.OcularExam.optionsODOS)
            {
                <input type="checkbox" id="onDescriptor" name="OcularExam.onDescriptor" value="@option" /> @option<br />;
            }
        }


    </div>

    <div>

        <div class="form-group">
            <input type="submit" value="Create" />
        </div>
</form>