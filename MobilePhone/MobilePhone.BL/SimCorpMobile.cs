using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using UnitMeasures;

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
                Weight = new Mass(0.188),
                Hight = new Length(0.17),
                Width = new Length(0.07)
            };

            __keyBoard = new KeyBoard

            {
                KeyBoardCulture = CultureInfo.CurrentCulture
            };
            __battery = new Battery
            {
                BatteryUseDuration = new Time(36000)
            };
        }

        public override ScreenBase Screen
        {get { return __OLEDScreen; } }

        public override KeyBoard KeyBoard
        { get { return __keyBoard; } }

        public override Battery Battery
        { get { return __battery; } }

        public ConsoleColor ImageColor
        { get { return ConsoleColor.Magenta; } }

    }
   }
