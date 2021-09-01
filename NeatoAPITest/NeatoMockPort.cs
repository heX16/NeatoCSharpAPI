namespace NeatoAPITest
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// This is a mock of a SerialPort connected to a Neato XV-15.
    /// </summary>
    public class NeatoMockPort : System.IO.Ports.SerialPort
    {
        /// <summary>
        /// Indicates whether or not this port is open.
        /// </summary>
        private bool isOpen;

        /// <summary>
        /// Buffer for reading text from the simulated port.
        /// </summary>
        private string buffer;

        /// <summary>
        /// Initializes a new instance of the <see cref="NeatoMockPort"/> class.
        /// </summary>
        public NeatoMockPort()
        {
            CanConnectToNeato = true;
            isOpen = false;
            buffer = string.Empty;
            AddNoReplyCommands();
        }

        /// <summary>
        /// Gets or sets a value indicating whether this port can connect to a Neato.
        /// </summary>
        public bool CanConnectToNeato { get; set; }

        /// <summary>
        /// Simulates opening the connection to a Neato.
        /// </summary>
        public new void Open()
        {
            if (!CanConnectToNeato)
            {
                throw new IOException();
            }
            else
            {
                if (isOpen)
                {
                    throw new InvalidOperationException("Port is already open!");
                }
                else
                {
                    isOpen = true;
                }
            }
        }

        /// <summary>
        /// Closes simulated Neato connection.
        /// </summary>
        public new void Close()
        {
            isOpen = false;
            buffer = string.Empty;
        }

        /// <summary>
        /// The is connected.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public new bool IsOpen()
        {
            return isOpen;
        }

        /// <summary>
        /// The discard in buffer.
        /// </summary>
        public new void DiscardInBuffer()
        {
            // TODO: Find out if this needs to do anything else...
            buffer = string.Empty;
        }

        /// <summary>
        /// Reads any existing data in the buffer.
        /// </summary>
        /// <returns>
        /// Any text in the buffer.
        /// </returns>
        public new string ReadExisting()
        {
            if (!isOpen)
            {
                throw new InvalidOperationException("Port is not open!");
            }

            var result = buffer;
            buffer = string.Empty;

            return result;
        }

        /// <summary>
        /// Writes a line to the simulated Neato.
        /// </summary>
        /// <param name="command">
        /// Command to be sent to Neato.
        /// </param>
        /// <exception cref="InvalidOperationException">Thrown if port isn't open.</exception>
        /// <exception cref="ArgumentNullException">Thrown if <see cref="command"/> is null.</exception>
        public new void WriteLine(string command)
        {
            if (!isOpen)
            {
                throw new InvalidOperationException("Port is not open!");
            }
            
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            
            if (noReplyCommands.Contains(command))
            {
                return;
            }

            switch (command)
            {
                case "GetVersion":
                    buffer += replyGetVersion;
                    break;
                case "GetAccel":
                    buffer += replyGetAccel;
                    break;
                case "GetMotors":
                    buffer += replyGetMotors;
                    break;
                case "GetDigitalSensors":
                    buffer += replyGetDigitalSensors;
                    break;
                case "GetCharger":
                    buffer += replyGetCharger;
                    break;
                default:
                    buffer = "Unknown Cmd: '" + command + "'";
                    break;
            }
        }

        #region Command replies

        /// <summary>
        /// List of commands that do not return anything.
        /// </summary>
        private List<string> noReplyCommands = new List<string>();

        private void AddNoReplyCommands()
        {
            string[] list = { "TestMode", "TestMode On", "TestMode Off" };
            foreach(var word in list)
            {
                noReplyCommands.Add(word);
            }
        }

        /// <summary>
        /// Response to GetVersion.
        /// </summary>
        private string replyGetVersion = "GetVersion\n\rComponent,Major,Minor,Build\n\rModelID,-1,XV15,\n\rConfigID,1,,\n\rSerial Number,WTD48311DD,0047522,P\n\rSoftware,2,6,15840\n\rBatteryType,1,NIMH_12CELL,\n\rBlowerType,1,BLOWER_ORIG,\n\rBrushSpeed,1200,,\n\rBrushMotorType,1,BRUSH_MOTOR_ORIG,\n\rSideBrushType,1,SIDE_BRUSH_NONE,\n\rWheelPodType,1,WHEEL_POD_ORIG,\n\rDropSensorType,1,DROP_SENSOR_ORIG,\n\rMagSensorType,1,MAG_SENSOR_ORIG,\n\rWallSensorType,1,WALL_SENSOR_ORIG,\n\rLocale,1,LOCALE_USA,\n\rLDS Software,V2.6.15295,,\n\rLDS Serial,WTD37111AA-0052197,,\n\rLDS CPU,F2802x/c001,,\n\rMainBoard Vendor ID,543,,\n\rMainBoard Serial Number,38803,,\n\rMainBoard Version,7,1,\n\rChassisRev,1,,\n\rUIPanelRev,1,,\n\r" + (char)26;

        /// <summary>
        /// Response to GetAccel.
        /// </summary>
        private string replyGetAccel = "GetAccel\n\rLabel,Value\n\rPitchInDegrees,  2.05\n\rRollInDegrees,  0.02\n\rXInG, 0.000\n\rYInG, 0.038\n\rZInG, 1.065\n\rSumInG, 1.066\n\r" + (char)26;

        /// <summary>
        /// Response to GetMotors.
        /// </summary>
        private string replyGetMotors = "GetMotors\n\rParameter,Value\n\rBrush_MaxPWM,65536\n\rBrush_PWM,0\n\rBrush_mVolts,0\n\rBrush_Encoder,0\n\rBrush_RPM, 0\n\rVacuum_MaxPWM,65536\n\rVacuum_PWM,0\n\rVacuum_CurrentInMA,13\n\rVacuum_Encoder,1\n\rVacuum_RPM, 0\n\rLeftWheel_MaxPWM,65536\n\rLeftWheel_PWM,0\n\rLeftWheel_mVolts,0\n\rLeftWheel_Encoder,0\n\rLeftWheel_PositionInMM,0\n\rLeftWheel_RPM,0\n\rRightWheel_MaxPWM,65536vRightWheel_PWM,0\n\rRightWheel_mVolts,0\n\rRightWheel_Encoder,0\n\rRightWheel_PositionInMM,0\n\rRightWheel_RPM,0vLaser_MaxPWM,65536\n\rLaser_PWM,0\n\rLaser_mVolts,0\n\rLaser_Encoder,0\n\rLaser_RPM, 0\n\rCharger_MaxPWM,65536\n\rCharger_PWM,0\n\rCharger_mAH, 0\n\r" + (char)26;

        /// <summary>
        /// Response to GetDigitalSensors.
        /// </summary>
        private string replyGetDigitalSensors = "GetDigitalSensors\n\rDigital Sensor Name, Value\n\rSNSR_DC_JACK_CONNECT,0\n\rSNSR_DUSTBIN_IS_IN,1\n\rSNSR_LEFT_WHEEL_EXTENDED,0\n\rSNSR_RIGHT_WHEEL_EXTENDED,0\n\rLSIDEBIT,0\n\rLFRONTBIT,0\n\rRSIDEBIT,0\n\rRFRONTBIT,0\n\r" + (char)26;

        /// <summary>
        /// Response to GetCharger.
        /// </summary>
        private string replyGetCharger = "GetCharger\n\rLabel,Value\n\rFuelPercent,42\n\rBatteryOverTemp,0\n\rChargingActive,0\n\rChargingEnabled,1\n\rConfidentOnFuel,0\n\rOnReservedFuel,0\n\rEmptyFuel,0\n\rBatteryFailure,0\n\rExtPwrPresent,0\n\rThermistorPresent[0],1\n\rThermistorPresent[1],1\n\rBattTempCAvg[0],34\n\rBattTempCAvg[1],34\n\rVBattV,16.95\n\rVExtV,0.74\n\rCharger_mAH,0\n\rMaxPWM,65536\n\rPWM,0\n\r" + (char)26;

        /// <summary>
        /// Response to GetCharger.
        /// </summary>
        private string replyGetWarranty = "GetWarranty\n\r0001a0c9\n\r0072\n\rb76e922d\n\r" + (char)26;

        /// <summary>
        /// Response to GetSchedule.
        /// </summary>
        private string replyGetSchedule = "GetSchedule\n\rSchedule is Enabled\n\rSun 00:00 - None -\n\rMon 00:00 - None -\n\rTue 00:00 - None -\n\rWed 00:00 - None -\n\rThu 00:00 - None -\n\rFri 00:00 - None -\n\rSat 00:00 - None -\n\r" + (char)26;

        /// <summary>
        /// Response to GetButtons.
        /// </summary>
        private string replyGetButtons = "GetButtons\n\rButton Name,Pressed\n\rBTN_SOFT_KEY,0\n\rBTN_SCROLL_UP,0\n\rBTN_START,0\n\rBTN_BACK,0\n\rBTN_SCROLL_DOWN,0\n\r" + (char)26;

        /// <summary>
        /// Response to GetAnalogSensors.
        /// </summary>
        private string replyGetAnalogSensors = "GetAnalogSensors\n\rSensorName,Value\n\rWallSensorInMM,63\n\rBatteryVoltageInmV,16671\n\rLeftDropInMM,60\n\rRightDropInMM,60\n\rRightMagSensor,0\n\rLeftMagSensor,0\n\rXTemp0InC,-30\n\rXTemp1InC,15\n\rVacuumCurrentInmA,13\n\rChargeVoltInmV,745\n\rNotConnected1,12\n\rBatteryTemp1InC,30\n\rNotConnected2,15\n\rCurrentInmA,83\n\rNotConnected3,9\n\rBatteryTemp0InC,30\n\r" + (char)26;

        /// <summary>
        /// Response to GetCalInfo.
        /// </summary>
        private string replyGetCalInfo = "GetCalInfo\n\rParameter,Value\n\rLDSOffset,0\n\rXAccel,0\n\rYAccel,0\n\rZAccel,0\n\rRTCOffset,85868\n\rLCDContrast,39\n\rRDropMin,233\n\rRDropMid,76\n\rRDropMax,32\n\rLDropMin,246\n\rLDropMid,72\n\rLDropMax,29\n\rWallMin,737\n\rWallMid,224\n\rWallMax,100\n\r" + (char)26;

        /// <summary>
        /// Response to GetTime.
        /// </summary>
        private string replyGetTime = "GetTime\n\rSunday 18:52:24\n\r" + (char)26;

        /// <summary>
        /// Response to GetLDSScan.
        /// </summary>
        private string replyGetLDSScan = "GETLDSSCAN\n\rAngleInDegrees,DistInMM,Intensity,ErrorCodeHEX\n\r0,640,609,0\n\r1,639,612,0\n\r2,639,615,0\n\r3,639,580,0\n\r4,640,604,0\n\r5,641,588,0\n\r6,641,588,0\n\r7,642,610,0\n\r8,643,586,0\n\r9,644,576,0\n\r10,646,556,0\n\r11,648,565,0\n\r12,650,539,0\n\r13,652,572,0\n\r14,655,565,0\n\r15,658,510,0\n\r16,661,494,0\n\r17,664,497,0\n\r18,667,492,0\n\r19,671,507,0\n\r20,674,522,0\n\r21,679,491,0\n\r22,684,491,0\n\r23,687,459,0\n\r24,693,451,0\n\r25,698,479,0\n\r26,0,479,8021\n\r27,708,399,0\n\r28,709,224,0\n\r29,706,17,0\n\r30,0,0,8035\n\r31,0,0,8035\n\r32,0,0,8035\n\r33,0,0,8035\n\r34,774,88,0\n\r35,772,237,0\n\r36,782,335,0\n\r37,796,249,0\n\r38,810,171,0\n\r39,823,66,0\n\r40,0,0,8035\n\r41,0,0,8035\n\r42,0,0,8035\n\r43,844,18,0\n\r44,860,118,0\n\r45,744,42,0\n\r46,756,229,0\n\r47,0,0,8035\n\r48,0,0,8035\n\r49,801,211,0\n\r50,846,309,0\n\r51,846,292,0\n\r52,833,186,0\n\r53,807,218,0\n\r54,786,204,0\n\r55,772,274,0\n\r56,766,275,0\n\r57,0,0,8035\n\r58,532,380,0\n\r59,526,407,0\n\r60,521,388,0\n\r61,517,427,0\n\r62,513,479,0\n\r63,508,446,0\n\r64,530,195,0\n\r65,553,191,0\n\r66,0,0,8035\n\r67,0,0,8035\n\r68,0,0,8002\n\r69,0,0,8002\n\r70,901,57,0\n\r71,951,41,0\n\r72,999,56,0\n\r73,1047,57,0\n\r74,1314,93,0\n\r75,1338,146,0\n\r76,1191,125,0\n\r77,1178,165,0\n\r78,1164,181,0\n\r79,1180,80,0\n\r80,1209,17,0\n\r81,0,0,8035\n\r82,0,0,8035\n\r83,0,0,8035\n\r84,0,0,8035\n\r85,0,0,8035\n\r86,0,0,8035\n\r87,1306,54,0\n\r88,1289,135,0\n\r89,1283,114,0\n\r90,1284,91,0\n\r91,1284,64,0\n\r92,1283,28,0\n\r93,1284,6,0\n\r94,0,0,8035\n\r95,0,0,8035\n\r96,0,0,8035\n\r97,1286,31,0\n\r98,1287,41,0\n\r99,1287,69,0\n\r100,1289,39,0\n\r101,0,0,8002\n\r102,0,0,8002\n\r103,16558,93,0\n\r104,16559,127,0\n\r105,174,174,0\n\r106,16558,155,0\n\r107,16559,110,0\n\r108,16555,41,0\n\r109,1367,27,0\n\r110,1371,83,0\n\r111,1375,110,0\n\r112,1382,104,0\n\r113,1394,74,0\n\r114,1398,32,0\n\r115,0,0,8035\n\r116,0,0,8035\n\r117,0,0,8035\n\r118,0,0,8035\n\r119,0,0,8035\n\r120,1460,54,0\n\r121,1478,93,0\n\r122,1505,111,0\n\r123,1521,152,0\n\r124,1540,150,0\n\r125,1558,141,0\n\r126,1578,150,0\n\r127,1597,147,0\n\r128,1617,124,0\n\r129,1644,125,0\n\r130,1666,25,0\n\r131,0,0,8035\n\r132,0,0,8035\n\r133,0,0,8035\n\r134,0,0,8035\n\r135,352,164,0\n\r136,344,289,0\n\r137,343,284,0\n\r138,351,181,0\n\r139,365,423,0\n\r140,357,236,0\n\r141,349,430,0\n\r142,345,274,0\n\r143,318,320,0\n\r144,313,496,0\n\r145,311,490,0\n\r146,310,391,0\n\r147,308,355,0\n\r148,306,332,0\n\r149,306,345,0\n\r150,306,275,0\n\r151,323,296,0\n\r152,330,253,0\n\r153,326,287,0\n\r154,329,477,0\n\r155,0,0,8002\n\r156,523,114,0\n\r157,540,127,0\n\r158,558,56,0\n\r159,0,0,8035\n\r160,0,0,8035\n\r161,0,0,8035\n\r162,0,0,8035\n\r163,0,0,8035\n\r164,0,0,8035\n\r165,0,0,8035\n\r166,0,0,8035\n\r167,0,0,8035\n\r168,0,0,8035\n\r169,0,0,8035\n\r170,0,0,8035\n\r171,0,0,8035\n\r172,0,0,8035\n\r173,1759,12,0\n\r174,1763,31,0\n\r175,1765,22,0\n\r176,2170,14,0\n\r177,2173,21,0\n\r178,1834,11,0\n\r179,1819,15,0\n\r180,1754,14,0\n\r181,1760,58,0\n\r182,0,0,8035\n\r183,1081,40,0\n\r184,1073,322,0\n\r185,1075,313,0\n\r186,1077,305,0\n\r187,1080,297,0\n\r188,1081,294,0\n\r189,1085,261,0\n\r190,1094,24,0\n\r191,0,0,8035\n\r192,0,0,8035\n\r193,0,0,8035\n\r194,0,0,8021\n\r195,0,0,8035\n\r196,0,0,8035\n\r197,0,0,8035\n\r198,0,0,8035\n\r199,0,0,8035\n\r200,0,0,8035\n\r201,0,0,8035\n\r202,0,0,8035\n\r203,16521,62,0\n\r204,0,0,8035\n\r205,0,0,8003\n\r206,0,0,8003\n\r207,0,0,8003\n\r208,0,0,8003\n\r209,134,436,0\n\r210,0,0,8035\n\r211,0,0,8035\n\r212,0,0,8035\n\r213,0,0,8035\n\r214,0,0,8035\n\r215,0,0,8035\n\r216,16521,83,0\n\r217,139,574,0\n\r218,142,1099,0\n\r219,146,1482,0\n\r220,148,1449,0\n\r221,150,1516,0\n\r222,152,1469,0\n\r223,155,1451,0\n\r224,157,1423,0\n\r225,159,1336,0\n\r226,162,1338,0\n\r227,165,1284,0\n\r228,168,1270,0\n\r229,171,1213,0\n\r230,174,1197,0\n\r231,178,1145,0\n\r232,181,1066,0\n\r233,185,1009,0\n\r234,190,988,0\n\r235,194,946,0\n\r236,199,896,0\n\r237,204,878,0\n\r238,209,821,0\n\r239,215,782,0\n\r240,222,766,0\n\r241,228,717,0\n\r242,0,717,8021\n\r243,243,619,0\n\r244,251,612,0\n\r245,261,550,0\n\r246,271,490,0\n\r247,282,412,0\n\r248,292,275,0\n\r249,16685,45,0\n\r250,0,0,8035\n\r251,0,0,8035\n\r252,0,0,8035\n\r253,0,0,8035\n\r254,0,0,8035\n\r255,0,0,8035\n\r256,0,0,8035\n\r257,0,0,8035\n\r258,0,0,8035\n\r259,803,25,0\n\r260,873,29,0\n\r261,952,27,0\n\r262,0,0,8035\n\r263,0,0,8035\n\r264,0,0,8035\n\r265,0,0,8035\n\r266,0,0,8035\n\r267,0,0,8035\n\r268,2077,11,0\n\r269,2277,66,0\n\r270,2267,140,0\n\r271,2024,24,0\n\r272,2040,11,0\n\r273,2094,8,0\n\r274,2167,11,0\n\r275,2202,50,0\n\r276,2222,40,0\n\r277,2244,38,0\n\r278,2246,41,0\n\r279,2223,41,0\n\r280,2204,18,0\n\r281,2197,15,0\n\r282,0,0,8035\n\r283,0,0,8035\n\r284,0,0,8035\n\r285,0,0,8035\n\r286,0,0,8035\n\r287,0,0,8035\n\r288,1778,24,0\n\r289,1845,60,0\n\r290,1890,49,0\n\r291,1934,111,0\n\r292,1951,89,0\n\r293,1930,49,0\n\r294,1899,60,0\n\r295,1858,93,0\n\r296,1784,60,0\n\r297,1728,72,0\n\r298,1670,77,0\n\r299,1617,90,0\n\r300,1567,88,0\n\r301,1522,30,0\n\r302,955,66,0\n\r303,887,239,0\n\r304,878,252,0\n\r305,869,280,0\n\r306,861,84,0\n\r307,714,163,0\n\r308,700,350,0\n\r309,699,372,0\n\r10,701,340,0\n\r311,709,325,0\n\r312,720,300,0\n\r313,741,212,0\n\r314,751,158,0\n\r315,742,160,0\n\r316,771,163,0\n\r317,759,156,0\n\r318,780,157,0\n\r319,817,180,0\n\r320,838,268,0\n\r321,839,307,0\n\r322,827,322,0\n\r323,817,334,0\n\r324,806,312,0\n\r325,788,89,0\n\r326,0,0,8035\n\r327,0,0,8035\n\r328,0,0,8035\n\r329,0,0,8035\n\r330,0,0,8035\n\r331,0,0,8035\n\r332,745,154,0\n\r333,730,365,0\n\r334,723,413,0\n\r335,719,380,0\n\r336,716,295,0\n\r337,713,231,0\n\r338,710,156,0\n\r339,706,75,0\n\r340,0,0,8035\n\r341,667,57,0\n\r342,666,159,0\n\r343,666,277,0\n\r344,667,369,0\n\r345,667,475,0\n\r346,664,506,0\n\r347,661,521,0\n\r348,658,527,0\n\r349,655,529,0\n\r350,652,544,0\n\r351,650,546,0\n\r352,648,572,0\n\r353,647,537,0\n\r354,644,567,0\n\r355,644,571,0\n\r356,642,564,0\n\r357,641,571,0\n\r358,640,609,0\n\r359,640,611,0\n\rROTATION_SPEED,4.99\n\r" + (char)26;

        #endregion
    }
}
