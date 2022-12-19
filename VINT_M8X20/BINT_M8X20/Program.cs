using System;
using NXOpen;
using NXOpen.UF;
using System.Collections;
public class Program

{
    // class members
    private static Session theSession;
    private static UI theUI;
    private static UFSession theUfSession;
    public static Program theProgram;
    public static bool isDisposeCalled;

    //------------------------------------------------------------------------------
    // Constructor
    //------------------------------------------------------------------------------
    public Program()
    {
        try
        {
            theSession = Session.GetSession();
            theUI = UI.GetUI();
            theUfSession = UFSession.GetUFSession();
            isDisposeCalled = false;
        }
        catch (NXOpen.NXException ex)
        {
            // ---- Enter your exception handling code here -----
            // UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Error, ex.Message);
        }
    }

    //------------------------------------------------------------------------------
    //  Explicit Activation
    //      This entry point is used to activate the application explicitly
    //------------------------------------------------------------------------------
    public static int Main(string[] args)
    {
        int retValue = 0;
        try
        {
            theProgram = new Program();

            //TODO: Add your application code here 

            theProgram.Dispose();
        }
        catch (NXOpen.NXException ex)
        {
            // ---- Enter your exception handling code here -----

        }
        return retValue;
    }

    //------------------------------------------------------------------------------
    // Following method disposes all the class members
    //------------------------------------------------------------------------------
    public void Dispose()
    {
        try
        {
            if (isDisposeCalled == false)
            {
                Tag UFPart1;
                  string name1 = "VINT";
                    int units1 = 1;
                    theUfSession.Part.New(name1, units1, out UFPart1);
                    double[] l1_endpt1 = { 0, 0, 0.00 };
                    double[] l1_endpt2 = { 0, 6.5, 0.00 };  //A
                    double[] l2_endpt1 = { 0, 6.5, 0.00 };
                    double[] l2_endpt2 = { 5, 6.5, 0.00 };  //B
                    double[] l3_endpt1 = { 5, 6.5, 0.00 };
                    double[] l3_endpt2 = { 5, 4, 0.00 };  //C
                    double[] l4_endpt1 = { 5, 4, 0.00 };
                    double[] l4_endpt2 = { 25, 4, 0.00 }; //D
                    double[] l5_endpt1 = { 25, 4, 0.00 };
                    double[] l5_endpt2 = { 25, 0, 0.00 }; //E
                    double[] l6_endpt1 = { 25, 0, 0.00 };
                    double[] l6_endpt2 = { 0, 0, 0.00 };  //F
                    UFCurve.Line line1 = new UFCurve.Line();
                    UFCurve.Line line2 = new UFCurve.Line();
                    UFCurve.Line line3 = new UFCurve.Line();
                    UFCurve.Line line4 = new UFCurve.Line();
                    UFCurve.Line line5 = new UFCurve.Line();
                    UFCurve.Line line6 = new UFCurve.Line();
                line1.start_point = new double[3];
line1.start_point[0] = l1_endpt1[0];
line1.start_point[1] = l1_endpt1[1];
line1.start_point[2] = l1_endpt1[2];
line1.end_point = new double[3];
line1.end_point[0] = l1_endpt2[0];
line1.end_point[1] = l1_endpt2[1];
line1.end_point[2] = l1_endpt2[2];
line2.start_point = new double[3];
line2.start_point[0] = l2_endpt1[0];
line2.start_point[1] = l2_endpt1[1];
line2.start_point[2] = l2_endpt1[2];
line2.end_point = new double[3];
line2.end_point[0] = l2_endpt2[0];
line2.end_point[1] = l2_endpt2[1];
line2.end_point[2] = l2_endpt2[2];
line3.start_point = new double[3];
line3.start_point[0] = l3_endpt1[0];
line3.start_point[1] = l3_endpt1[1];
line3.start_point[2] = l3_endpt1[2];
line3.end_point = new double[3];
line3.end_point[0] = l3_endpt2[0];
line3.end_point[1] = l3_endpt2[1];
line3.end_point[2] = l3_endpt2[2];
line4.start_point = new double[3];
line4.start_point[0] = l4_endpt1[0];
line4.start_point[1] = l4_endpt1[1];
line4.start_point[2] = l4_endpt1[2];
line4.end_point = new double[3];
line4.end_point[0] = l4_endpt2[0];
line4.end_point[1] = l4_endpt2[1];
line4.end_point[2] = l4_endpt2[2];
line5.start_point = new double[3];
line5.start_point[0] = l5_endpt1[0];
line5.start_point[1] = l5_endpt1[1];
line5.start_point[2] = l5_endpt1[2];
line5.end_point = new double[3];
line5.end_point[0] = l5_endpt2[0];
line5.end_point[1] = l5_endpt2[1];
line5.end_point[2] = l5_endpt2[2];
line6.start_point = new double[3];
line6.start_point[0] = l6_endpt1[0];
line6.start_point[1] = l6_endpt1[1];
line6.start_point[2] = l6_endpt1[2];
line6.end_point = new double[3];
line6.end_point[0] = l6_endpt2[0];
line6.end_point[1] = l6_endpt2[1];
line6.end_point[2] = l6_endpt2[2];
                Tag[] objarray1 = new Tag[7];
theUfSession.Curve.CreateLine(ref line1, out
objarray1[0]);
theUfSession.Curve.CreateLine(ref line2, out
objarray1[1]);
theUfSession.Curve.CreateLine(ref line3, out
objarray1[2]);
theUfSession.Curve.CreateLine(ref line4, out
objarray1[3]);
theUfSession.Curve.CreateLine(ref line5, out
objarray1[4]);
theUfSession.Curve.CreateLine(ref line6, out
objarray1[5]);
                double[] ref_pt1 = new double[3];
ref_pt1[0] = 0.00;
ref_pt1[1] = 0.00;
ref_pt1[2] = 0.00;
double[] direction1 = { 1.00, 0.00, 0.00 };
string[] limit1 = { "0", "360" };

                Tag[] features1;
                theUfSession.Modl.CreateRevolved(objarray1, limit1,
ref_pt1, direction1, FeatureSigns.Nullsign, out features1);

                Tag feat1 = features1[0];
                Tag cyl_tag, obj_id_camf, blend1;
                Tag[] Edge_array_cyl, list1, list2;
                int ecount;
                theUfSession.Modl.AskFeatBody(feat1, out cyl_tag);
                theUfSession.Modl.AskBodyEdges(cyl_tag, out
Edge_array_cyl);
                theUfSession.Modl.AskListCount(Edge_array_cyl, out
ecount);
                ArrayList arr_list1 = new ArrayList();
                ArrayList arr_list2 = new ArrayList();

                for (int ii = 0; ii < ecount; ii++)
                {
                    Tag edge;
                    theUfSession.Modl.AskListItem(Edge_array_cyl, ii,
                    out edge);
                    if (ii == 1)
                    {
                        arr_list1.Add(edge);
                    }
                    if (ii == 2)
                    {
                        arr_list2.Add(edge);
                    }
                }
                list1 = (Tag[])arr_list1.ToArray(typeof(Tag));
                list2 = (Tag[])arr_list2.ToArray(typeof(Tag));

                list1 = (Tag[])arr_list1.ToArray(typeof(Tag));
                string offset1 = "1"; 
                string offset2 = "1";
                string ang = "45";
                theUfSession.Modl.CreateChamfer(3, offset1, offset2, ang,
                list2, out obj_id_camf);

                int allow_smooth = 0;
                int allow_cliff = 0;
                int allow_notch = 0;
                double vrb_tol = 0.0;
                theUfSession.Modl.CreateBlend("0.4", list1, allow_smooth, 
                    allow_cliff, allow_notch, vrb_tol, out blend1);

                double[] direction3 = { 0.0, 0.0, 1.0 };
                double[] ref_pt3 = new double[3];
                string taper_angel3 = "0.0";
                string[] limit3 = { "-18", "18" };
                Tag[] objarray3 = new Tag[7];
                Tag[] features3;
                double[] l9_endpt1 = { 0, 1, 0 };
                double[] l9_endpt2 = { 2.50, 1, 0 };
                double[] l10_endpt1 = { 2.50, 1, 0 };
                double[] l10_endpt2 = { 2.50, -1, 0 };
                double[] l11_endpt1 = { 2.50, -1, 0 };
                double[] l11_endpt2 = { 0, -1, 0 };
                double[] l12_endpt1 = { 0, -1, 0 };
                double[] l12_endpt2 = { 0, 1, 0 };
                UFCurve.Line line9 = new UFCurve.Line();
                UFCurve.Line line10 = new UFCurve.Line();
                UFCurve.Line line11 = new UFCurve.Line();
                UFCurve.Line line12 = new UFCurve.Line();
                SetPointsToLine(ref line9, l9_endpt1, l9_endpt2);
                SetPointsToLine(ref line10, l10_endpt1, l10_endpt2);
                SetPointsToLine(ref line11, l11_endpt1, l11_endpt2);
                SetPointsToLine(ref line12, l12_endpt1, l12_endpt2);
                theUfSession.Curve.CreateLine(ref line9, out objarray3[0]);
                theUfSession.Curve.CreateLine(ref line10, out objarray3[1]);
                theUfSession.Curve.CreateLine(ref line11, out objarray3[2]);
                theUfSession.Curve.CreateLine(ref line12, out objarray3[3]);

                theUfSession.Modl.CreateExtruded(objarray3, taper_angel3, limit3, ref_pt3, direction3, FeatureSigns.Negative, out features3);

                theUfSession.Part.Save();
            }
            isDisposeCalled = true;
        }
        catch (NXOpen.NXException ex)
        {
            // ---- Enter your exception handling code here -----

        }
    }

    private void SetPointsToLine(ref UFCurve.Line line11, double[] l11_endpt1, double[] l11_endpt2)
    {
        line11.start_point = new double[3];
        line11.end_point = new double[3];
        l11_endpt1.CopyTo(line11.start_point,0);
        l11_endpt2.CopyTo(line11.end_point,0);
    }

    public static int GetUnloadOption(string arg)
    {
        //Unloads the image explicitly, via an unload dialog
        //return System.Convert.ToInt32(Session.LibraryUnloadOption.Explicitly);

        //Unloads the image immediately after execution within NX
        // return System.Convert.ToInt32(Session.LibraryUnloadOption.Immediately);

        //Unloads the image when the NX session terminates
        return System.Convert.ToInt32(Session.LibraryUnloadOption.AtTermination);
    }

}