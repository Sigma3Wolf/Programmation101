using System.Diagnostics;

namespace Programmation101 {
    public partial class Form1 : Form {
        //Hungarian notation
        //https://www.lenovo.com/us/en/glossary/what-is-hungarian-notation/?orgRef=https%253A%252F%252Fwww.google.com%252F

        //Camel Case  : is a casing style where words are joined together without any spaces, and each new word starts with a capital letter except for the first word.
        //Pascal Case : is similar to Camel Case, but the first letter of each word is capitalized.
        //https://dev.to/ankitmalikg/difference-among-casings-snake-case-vs-camel-case-vs-pascal-case-vs-kebab-case-2m8b#:~:text=Pascal%20Case%20is%20similar%20to,C%23%2C%20Java%2C%20and%20TypeScript.

        private sbyte sbyId = 0;
        private byte bytId = 0;

        private int intId = 0;
        private uint untId = 0;

        private long lngId = 0;
        private ulong ulnId = 0;

        private float fltId = 0;
        private double dblId = 0;
        private string strId = "";

        private byte bytRed = 0;
        private byte bytGreen = 50;
        private byte bytBlue = 250;


        //sbyte = -128 à 127
        //Byte =     0 à 255     : 00000000  base 2: 0,1;  base 10: 0,1,2,3,4,5,6,7,8,9, base 16: 0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F
        //  1 byte = 8 bit
        //  8 bit: 11111111          =        255   (256 valeurs possible)
        // 16 bit: 11111111 11111111 =      65535 (65536 valeurs possible)
        // 32 bit: 11111111 11111111 = 4294967295 (4294967296 valeurs possible)

        //intId  = - 2 147 483 648 à 2 147 483 647
        //uintId = 0 to 4294967295

        //long lngId = -9 223 372 036 854 775 808 à 9 223 372 036 854 775 807
        //ulong ulnId = 0 to 18446744073709551615

        //float -3,4028235E+38 à 3,4028234E+38
        //double -1,79769313486231570E+308 à 1,7976931348623157E+308
        //bool = TRUE / FALSE                0/1 (1 bit)

        //string = "Bonjour"

        //RGB(0, 50, 250)  // Hex #0032FA  Hex(00, 32, FA)
        //RGB(bytRed, bytGreen, bytBlue)

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //https://stackoverflow.com/questions/425389/c-sharp-equivalent-of-sql-server-datatypes
            sbyte bytId3 = 0;
            SByte bytId4 = 0;

            byte bytId1 = 0;
            Byte bytId2 = 0;

            int intId1 = 0;
            Int32 intId2 = 0;

            uint intId3 = 0;
            UInt32 intId4 = 0;

            long lngId1 = 0;
            Int64 lngId2 = 0;

            ulong lngId3 = 0;
            UInt64 lngId4 = 0;

            float fltId1 = 0;
            Single fltId2 = 0;

            double dblId1 = 0;
            Double dblId2 = 0;

            bool boolId1 = false;
            Boolean boolId2 = false;

            char chrId1 = '\t';
            Char chrId2 = '\0';
            Char chrId3 = 'T';
            Char chrId4 = 't';


            string strId1 = "Hello";
            String strId2 = "Bonjour";
            string strId3 = string.Empty;
            string strId4 = "";

            string strId5a = "Hello";
            string strId5b = "One";
            string strId5c = "Two";

            string strMax = "J9L 2A4";
            //nvarchar(7) strMax = "J9L 2A4";

            string[] strId5 = { "Hello", "One", "Two" };
            //strId5[0] = "Hello";
            //strId5[1] = "One";
            //strId5[2] = "Two";

            //Database / Base de données
            //MySql - Linux          (acheter = 0$)           (louer = 2$/mois)
            //MsSql - Microsoft $$$  (acheter = ~1000$/année) (Louer = ~13$/mois)

            //https://stackoverflow.com/questions/64400149/is-there-a-c-equivalent-of-cs-decimal-type
            // dcmId1 = 0;
            
            Decimal dcmId2 = 0.35m;  //0.35$
            Debug.WriteLine(dcmId2.ToString("0.00"));

            //min 0001-01-01 00:00:00
            //max 9999-12-31 23:59:59
            DateTime datId2 = DateTime.MinValue;
            Debug.WriteLine(datId2.ToString());
            datId2 = datId2.AddDays(1);
            //Debug.WriteLine(datId2.ToString());

            byte bytId5 = 10;
            bytId5 = (byte)(bytId5 + 1);
            //Debug.WriteLine(bytId5.ToString());

            //https://youtube.com/watch?v=KioVcstEF9E
            //https://youtu.be/KioVcstEF9E

            //Base
            //Base  2: "01"
            //Base  8: "01234567" = 0-255 = 256   //11111111
            //Base 10: "0123456789"
            //Base 16: "0123456789ABCDEF"

            //Non officiele:
            //Base 32: "0123456789ACDEFGHJKLMNPQRTUVWXYZ"
            //Base 55: "0123456789ACDEFGHJKLMNPQRTUVWXYZabdefghijkmnpqrstuvwxyz"
        }
    }
}
