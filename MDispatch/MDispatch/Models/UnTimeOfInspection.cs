using Prism.Mvvm;
using System;

namespace MDispatch.Models
{
    public class UnTimeOfInspection : BindableBase
    {
        public bool IsInspection { get; private set; } = false;
        public bool ISMaybiInspection { get; set; }
        public string TimeOfInspection { get; private set; }
        public string IdDriver { get; private set; }

        public UnTimeOfInspection(string statusInspection = null)
        {
            bool IsInspectionDriver;
            bool IsInspectionToDayDriver;
            if (statusInspection != null)
            {
                string[] arrData = statusInspection.Split(',');
                IsInspectionDriver = Convert.ToBoolean(arrData[0]);
                IsInspectionToDayDriver = Convert.ToBoolean(arrData[1]);
                TimeOfInspection = arrData[2] + " Hours";
                IdDriver = arrData[3];
                if (IsInspectionDriver)
                {
                    ISMaybiInspection = true;
                    if (IsInspectionToDayDriver)
                    {
                        IsInspection = false;
                    }
                    else
                    {
                        IsInspection = true;
                    }
                }
                else
                {
                    ISMaybiInspection = false;
                    IsInspection = true;
                }
            }
        }

        public string GetColorBlock
        {
            get
            {
                string color = "";
                if (TimeOfInspection == "1 Hours" || TimeOfInspection == "0 Hours")
                {
                    color = "#FF2C2C";
                }
                else if (TimeOfInspection == "2 Hours")
                {
                    color = "#FF5C00";
                }
                else if (TimeOfInspection == "3 Hours")
                {
                    color = "#FF9314";
                }
                else if (TimeOfInspection == "4 Hours")
                {
                    color = "#FFE600";
                }
                else if (TimeOfInspection == "5 Hours")
                {
                    color = "#BDFF00";
                }
                else if (TimeOfInspection == "6 Hours")
                {
                    color = "#69EB2C";
                }
                else if (TimeOfInspection == "7 Hours")
                {
                    color = "#2C5DEB";
                }
                else
                {
                    color = "#2C5DEB";
                }
                return color;
            }
        }

        public string GetColorBlockOpacity
        {
            get
            {
                string color = "";
                if (TimeOfInspection == "1 Hours" || TimeOfInspection == "0 Hours")
                {
                    color = "#ffeeee";
                }
                else if (TimeOfInspection == "2 Hours")
                {
                    color = "#fff2eb";
                }
                else if (TimeOfInspection == "3 Hours")
                {
                    color = "#fff6ec";
                }
                else if (TimeOfInspection == "4 Hours")
                {
                    color = "#fffdeb";
                }
                else if (TimeOfInspection == "5 Hours")
                {
                    color = "#faffeb";
                }
                else if (TimeOfInspection == "6 Hours")
                {
                    color = "#f3fdee";
                }
                else if (TimeOfInspection == "7 Hours")
                {
                    color = "#eef2fd";
                }
                else
                {
                    color = "#eef2fd";
                }
                return color;
            }
        }


        public string TimeOfStatus
        {
            get
            {
                string status = "";
                if(TimeOfInspection == "7 Hours" || TimeOfInspection == "6 Hours" || TimeOfInspection == "5 Hours" || TimeOfInspection == "4 Hours")
                {
                    status = "You can pass the inspection after";
                }
                else if(TimeOfInspection == "3 Hours" || TimeOfInspection == "2 Hours")
                {
                    status = "best time to pass inspection";
                }
                else if (TimeOfInspection == "1 Hours")
                {
                    status = "Pass inspection now";
                }
                else if (TimeOfInspection == "0 Hours")
                {
                    status = "Pass inspection now";
                }
                return status;
            }
        }
    }
}