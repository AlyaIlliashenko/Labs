using System.Globalization;

namespace MobilePhone.BL
{
    public class KeyBoard
    {
        public CultureInfo KeyBoardCulture { get; set; }

        public override string ToString() => ($"KeyBoard Culture: {KeyBoardCulture.ToString()}");
    }
}