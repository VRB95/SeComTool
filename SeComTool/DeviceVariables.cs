using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeComTool
{
    class Model
    {
        public int class_code;
        public string class_name;
        public int gdc_obj_number;
        public Dictionary<int, string> units;

        public Model(int m_class_code, string m_class_name, int m_gdc_obj_number, Dictionary<int, string> m_units)
        {
            this.class_code = m_class_code;
            this.class_name = m_class_name;
            this.gdc_obj_number = m_gdc_obj_number;
            this.units = m_units;
        }
    }
    class DeviceVariables
    {
        public List<Model> list_of_classes = new List<Model>();
        public DeviceVariables()
        {

            this.list_of_classes.Add(new Model(64, "Temperature", 44100, new Dictionary<int, string>()
                {
                    { 32, "Celsius"     },
                    { 33, "Fahrenheit"  },
                    { 34, "Rankine"     },
                    { 35, "Kelvin"      },
                }));

            this.list_of_classes.Add(new Model(65, "Pressure", 44200, new Dictionary<int, string>()
                {
                    {6,     "Psi"},
                    {7,     "Bars"},
                    {8,     "Millibars"},
                    {11,    "Pascals"},
                    {12,    "Kilopascals"},
                    {171,   "mH2O at 4°C"},
                }));

            this.list_of_classes.Add(new Model(67, "Velocity", 44300, new Dictionary<int, string>()
                {
                    {20, "Feet per second"  },
                    {21, "Meter per second" },
                }));

            this.list_of_classes.Add(new Model(68, "Volume", 44400, new Dictionary<int, string>()
                {
                    {40,    "Gallons"},
                    {41,    "Liters"},
                    {42,    "Imperial gallons"},
                    {43,    "Cubic meters"},
                    {46,    "Barrels"},
                    {111,   "Cubic yards"},
                    {112,   "Cubic feet"},
                    {113,   "Cubic Inches"},
                    {236,   "Hectoliters"},
                    {240,   "Milliliters"},
                    {241,   "Million imperial gallons"},
                    {242,   "Million gallons (U.S. liquid)"},
                    {243,   "Acre-foot"},
                    {249,   "User defined"},
                }));

            this.list_of_classes.Add(new Model(71, "MassFlow", 44500, new Dictionary<int, string>()
                {
                    {70,    "Grams per second"},
                    {71,    "Grams per minute"},
                    {72,    "Grams per hour"},
                    {73,    "Kilograms per Second"},
                    {74,    "Kilograms per Minute"},
                    {75,    "Kilograms per hour"},
                    {77,    "Metric tons per minute"},
                    {78,    "Metric tons per hour"},
                    {80,    "Pounds per second"},
                    {81,    "Pounds per minute"},
                    {82,    "Pounds per hour"},
                    {84,    "Short tons per minute"},
                    {85,    "Short tons per hour"},
                    {87,    "Long tons per hour"},
                }));

            this.list_of_classes.Add(new Model(72, "Conductance", 44600, new Dictionary<int, string>()
                {
                    {66, "Millisiemens per centimeter"},
                    {67, "Microsiemens per centimeter"},
                }));
        }
    }

}
