using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using NGenericDimensions;
using NGenericDimensions.Masses.MetricSI;
using NGenericDimensions.Lengths.MetricSI;

namespace MobilePhone.BL
{
    public class SimCorpMobile : MobilePhone
    {
        private readonly OLEDScreen __OLEDScreen;
        private readonly KeyBoard __keyBoard;
        private readonly Battery __battery;

        public SimCorpMobile()
        {
            __OLEDScreen = new OLEDScreen
            {
                Weight = new Mass<Kilograms, double>(0.188),
                Hight = new Length<Metres, double>(0.17),
                Width = new Length<Metres, double>(0.07)
            };

            __keyBoard = new KeyBoard
            {
                KeyBoardCulture = CultureInfo.CurrentCulture
            };

            __battery = new Battery
            {
                BatteryUseDuration = new TimeSpan(10, 30, 0)
            };
        }

        public override ScreenBase Screen => __OLEDScreen; 

        public override KeyBoard KeyBoard => __keyBoard; 

        public override Battery Battery => __battery;

        public ConsoleColor ImageColor => ConsoleColor.Magenta;

    }
   }
