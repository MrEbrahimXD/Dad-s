using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Father.Properties;


namespace Father
{
    public partial class calculations : Form
    {
        // Max Amount 1 => 120 ******** \\
        public static int max_1_amount = Settings.Default.max1;
        public static int max_2_amount = Settings.Default.max2;
        public static int max_3_amount = Settings.Default.max3;
        public static int max_4_amount = Settings.Default.max4;
        public static int max_5_amount = Settings.Default.max5;
        public static int max_6_amount = Settings.Default.max6;
        public static int max_7_amount = Settings.Default.max7;
        public static int max_8_amount = Settings.Default.max8;
        public static int max_9_amount = Settings.Default.max9;
        public static int max_10_amount = Settings.Default.max10;
        public static int max_11_amount = Settings.Default.max11;
        public static int max_12_amount = Settings.Default.max12;
        public static int max_13_amount = Settings.Default.max13;
        public static int max_14_amount = Settings.Default.max14;
        public static int max_15_amount = Settings.Default.max15;
        public static int max_16_amount = Settings.Default.max16;
        public static int max_17_amount = Settings.Default.max17;
        public static int max_18_amount = Settings.Default.max18;
        public static int max_19_amount = Settings.Default.max19;
        public static int max_20_amount = Settings.Default.max20;
        public static int max_21_amount = Settings.Default.max21;
        public static int max_22_amount = Settings.Default.max22;
        public static int max_23_amount = Settings.Default.max23;
        public static int max_24_amount = Settings.Default.max24;
        public static int max_25_amount = Settings.Default.max25;
        public static int max_26_amount = Settings.Default.max26;
        public static int max_27_amount = Settings.Default.max27;
        public static int max_28_amount = Settings.Default.max28;
        public static int max_29_amount = Settings.Default.max29;
        public static int max_30_amount = Settings.Default.max30;
        public static int max_31_amount = Settings.Default.max31;
        public static int max_32_amount = Settings.Default.max32;
        public static int max_33_amount = Settings.Default.max33;
        public static int max_34_amount = Settings.Default.max34;
        public static int max_35_amount = Settings.Default.max35;
        public static int max_36_amount = Settings.Default.max36;
        public static int max_37_amount = Settings.Default.max37;
        public static int max_38_amount = Settings.Default.max38;
        public static int max_39_amount = Settings.Default.max39;
        public static int max_40_amount = Settings.Default.max40;
        public static int max_41_amount = Settings.Default.max41;
        public static int max_42_amount = Settings.Default.max42;
        public static int max_43_amount = Settings.Default.max43;
        public static int max_44_amount = Settings.Default.max44;
        public static int max_45_amount = Settings.Default.max45;
        public static int max_46_amount = Settings.Default.max46;
        public static int max_47_amount = Settings.Default.max47;
        public static int max_48_amount = Settings.Default.max48;
        public static int max_49_amount = Settings.Default.max49;
        public static int max_50_amount = Settings.Default.max50;
        public static int max_51_amount = Settings.Default.max51;
        public static int max_52_amount = Settings.Default.max52;
        public static int max_53_amount = Settings.Default.max53;
        public static int max_54_amount = Settings.Default.max54;
        public static int max_55_amount = Settings.Default.max55;
        public static int max_56_amount = Settings.Default.max56;
        public static int max_57_amount = Settings.Default.max57;
        public static int max_58_amount = Settings.Default.max58;
        public static int max_59_amount = Settings.Default.max59;
        public static int max_60_amount = Settings.Default.max60;
        public static int max_61_amount = Settings.Default.max61;
        public static int max_62_amount = Settings.Default.max62;
        public static int max_63_amount = Settings.Default.max63;
        public static int max_64_amount = Settings.Default.max64;
        public static int max_65_amount = Settings.Default.max65;
        public static int max_66_amount = Settings.Default.max66;
        public static int max_67_amount = Settings.Default.max67;
        public static int max_68_amount = Settings.Default.max68;
        public static int max_69_amount = Settings.Default.max69;
        public static int max_70_amount = Settings.Default.max70;
        public static int max_71_amount = Settings.Default.max71;
        public static int max_72_amount = Settings.Default.max72;
        public static int max_73_amount = Settings.Default.max73;
        public static int max_74_amount = Settings.Default.max74;
        public static int max_75_amount = Settings.Default.max75;
        public static int max_76_amount = Settings.Default.max76;
        public static int max_77_amount = Settings.Default.max77;
        public static int max_78_amount = Settings.Default.max78;
        public static int max_79_amount = Settings.Default.max79;
        public static int max_80_amount = Settings.Default.max80;
        public static int max_81_amount = Settings.Default.max81;
        public static int max_82_amount = Settings.Default.max82;
        public static int max_83_amount = Settings.Default.max83;
        public static int max_84_amount = Settings.Default.max84;
        public static int max_85_amount = Settings.Default.max85;
        public static int max_86_amount = Settings.Default.max86;
        public static int max_87_amount = Settings.Default.max87;
        public static int max_88_amount = Settings.Default.max88;
        public static int max_89_amount = Settings.Default.max89;
        public static int max_90_amount = Settings.Default.max90;
        public static int max_91_amount = Settings.Default.max91;
        public static int max_92_amount = Settings.Default.max92;
        public static int max_93_amount = Settings.Default.max93;
        public static int max_94_amount = Settings.Default.max94;
        public static int max_95_amount = Settings.Default.max95;
        public static int max_96_amount = Settings.Default.max96;
        public static int max_97_amount = Settings.Default.max97;
        public static int max_98_amount = Settings.Default.max98;
        public static int max_99_amount = Settings.Default.max99;
        public static int max_100_amount = Settings.Default.max100;
        public static int max_101_amount = Settings.Default.max101;
        public static int max_102_amount = Settings.Default.max102;
        public static int max_103_amount = Settings.Default.max103;
        public static int max_104_amount = Settings.Default.max104;
        public static int max_105_amount = Settings.Default.max105;
        public static int max_106_amount = Settings.Default.max106;
        public static int max_107_amount = Settings.Default.max107;
        public static int max_108_amount = Settings.Default.max108;
        public static int max_109_amount = Settings.Default.max109;
        public static int max_110_amount = Settings.Default.max110;
        public static int max_111_amount = Settings.Default.max111;
        public static int max_112_amount = Settings.Default.max112;
        public static int max_113_amount = Settings.Default.max113;
        public static int max_114_amount = Settings.Default.max114;
        public static int max_115_amount = Settings.Default.max115;
        public static int max_116_amount = Settings.Default.max116;
        public static int max_117_amount = Settings.Default.max117;
        public static int max_118_amount = Settings.Default.max118;
        public static int max_119_amount = Settings.Default.max119;
        public static int max_120_amount = Settings.Default.max120;
        // ***************** \\ 

        public static int new_max_1_amount = max_1_amount - amount_1;
        





        // Default amounts ************* \\



        public static int amount_1;
        public static int amount_2;
        public static int amount_3;
        public static int amount_4;
        public static int amount_5;
        public static int amount_6;
        public static int amount_7;
        public static int amount_8;
        public static int amount_9;
        public static int amount_10;
        public static int amount_11;
        public static int amount_12;
        public static int amount_13;
        public static int amount_14;
        public static int amount_15;
        public static int amount_16;
        public static int amount_17;
        public static int amount_18;
        public static int amount_19;
        public static int amount_20;
        public static int amount_21;
        public static int amount_22;
        public static int amount_23;
        public static int amount_24;
        public static int amount_25;
        public static int amount_26;
        public static int amount_27;
        public static int amount_28;
        public static int amount_29;
        public static int amount_30;
        public static int amount_31;
        public static int amount_32;
        public static int amount_33;
        public static int amount_34;
        public static int amount_35;
        public static int amount_36;
        public static int amount_37;
        public static int amount_38;
        public static int amount_39;
        public static int amount_40;
        public static int amount_41;
        public static int amount_42;
        public static int amount_43;
        public static int amount_44;
        public static int amount_45;
        public static int amount_46;
        public static int amount_47;
        public static int amount_48;
        public static int amount_49;
        public static int amount_50;
        public static int amount_51;
        public static int amount_52;
        public static int amount_53;
        public static int amount_54;
        public static int amount_55;
        public static int amount_56;
        public static int amount_57;
        public static int amount_58;
        public static int amount_59;
        public static int amount_60;
        public static int amount_61;
        public static int amount_62;
        public static int amount_63;
        public static int amount_64;
        public static int amount_65;
        public static int amount_66;
        public static int amount_67;
        public static int amount_68;
        public static int amount_69;
        public static int amount_70;
        public static int amount_71;
        public static int amount_72;
        public static int amount_73;
        public static int amount_74;
        public static int amount_75;
        public static int amount_76;
        public static int amount_77;
        public static int amount_78;
        public static int amount_79;
        public static int amount_80;
        public static int amount_81;
        public static int amount_82;
        public static int amount_83;
        public static int amount_84;
        public static int amount_85;
        public static int amount_86;
        public static int amount_87;
        public static int amount_88;
        public static int amount_89;
        public static int amount_90;
        public static int amount_91;
        public static int amount_92;
        public static int amount_93;
        public static int amount_94;
        public static int amount_95;
        public static int amount_96;
        public static int amount_97;
        public static int amount_98;
        public static int amount_99;
        public static int amount_100;
        public static int amount_101;
        public static int amount_102;
        public static int amount_103;
        public static int amount_104;
        public static int amount_105;
        public static int amount_106;
        public static int amount_107;
        public static int amount_108;
        public static int amount_109;
        public static int amount_110;
        public static int amount_111;
        public static int amount_112;
        public static int amount_113;
        public static int amount_114;
        public static int amount_115;
        public static int amount_116;
        public static int amount_117;
        public static int amount_118;
        public static int amount_119;
        public static int amount_120;


        public calculations()
        {
            InitializeComponent();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calculations_Load(object sender, EventArgs e)
        {
            

            label1.Text = $"0/{max_1_amount}";
            label2.Text = $"0/{max_2_amount}";
            label3.Text = $"0/{max_3_amount}";
            label4.Text = $"0/{max_4_amount}";
            label5.Text = $"0/{max_5_amount}";
            label6.Text = $"0/{max_6_amount}";
            label7.Text = $"0/{max_7_amount}";
            label8.Text = $"0/{max_8_amount}";
            label9.Text = $"0/{max_9_amount}";
            label10.Text = $"0/{max_10_amount}";
            label11.Text = $"0/{max_11_amount}";
            label12.Text = $"0/{max_12_amount}";
            label13.Text = $"0/{max_13_amount}";
            label14.Text = $"0/{max_14_amount}";
            label15.Text = $"0/{max_15_amount}";
            label16.Text = $"0/{max_16_amount}";
            label17.Text = $"0/{max_17_amount}";
            label18.Text = $"0/{max_18_amount}";
            label19.Text = $"0/{max_19_amount}";
            label20.Text = $"0/{max_20_amount}";
            label21.Text = $"0/{max_21_amount}";
            label22.Text = $"0/{max_22_amount}";
            label23.Text = $"0/{max_23_amount}";
            label24.Text = $"0/{max_24_amount}";
            label25.Text = $"0/{max_25_amount}";
            label26.Text = $"0/{max_26_amount}";
            label27.Text = $"0/{max_27_amount}";
            label28.Text = $"0/{max_28_amount}";
            label29.Text = $"0/{max_29_amount}";
            label30.Text = $"0/{max_30_amount}";
            label31.Text = $"0/{max_31_amount}";
            label32.Text = $"0/{max_32_amount}";
            label33.Text = $"0/{max_33_amount}";
            label34.Text = $"0/{max_34_amount}";
            label35.Text = $"0/{max_35_amount}";
            label36.Text = $"0/{max_36_amount}";
            label37.Text = $"0/{max_37_amount}";
            label38.Text = $"0/{max_38_amount}";
            label39.Text = $"0/{max_39_amount}";
            label40.Text = $"0/{max_40_amount}";
            label41.Text = $"0/{max_41_amount}";
            label42.Text = $"0/{max_42_amount}";
            label43.Text = $"0/{max_43_amount}";
            label44.Text = $"0/{max_44_amount}";
            label45.Text = $"0/{max_45_amount}";
            label46.Text = $"0/{max_46_amount}";
            label47.Text = $"0/{max_47_amount}";
            label48.Text = $"0/{max_48_amount}";
            label49.Text = $"0/{max_49_amount}";
            label50.Text = $"0/{max_50_amount}";
            label51.Text = $"0/{max_51_amount}";
            label52.Text = $"0/{max_52_amount}";
            label53.Text = $"0/{max_53_amount}";
            label54.Text = $"0/{max_54_amount}";
            label55.Text = $"0/{max_55_amount}";
            label56.Text = $"0/{max_56_amount}";
            label57.Text = $"0/{max_57_amount}";
            label58.Text = $"0/{max_58_amount}";
            label59.Text = $"0/{max_59_amount}";
            label60.Text = $"0/{max_60_amount}";

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (amount_1 < max_1_amount)
            {
                amount_1++;
                label1.Text = $"{amount_1}/{max_1_amount}";
                
            }
            else
            {
                MessageBox.Show("Amount is empty " , "Alert");
            }
            
            
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (amount_2 < max_2_amount)
            {
                amount_2++;
                label2.Text = $"{amount_2}/{max_2_amount}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (amount_3 < max_3_amount)
            {
                amount_3++;
                label3.Text = $"{amount_3}/{max_3_amount}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (amount_4 < max_4_amount)
            {
                amount_4++;
                label4.Text = $"{amount_4}/{max_4_amount}";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (amount_5 < max_5_amount)
            {
                amount_5++;
                label5.Text = $"{amount_5}/{max_5_amount}";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (amount_6 < max_6_amount)
            {
                amount_6++;
                label6.Text = $"{amount_6}/{max_6_amount}";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (amount_7 < max_7_amount)
            {
                amount_7++;
                label7.Text = $"{amount_7}/{max_7_amount}";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (amount_8 < max_8_amount)
            {
                amount_8++;
                label8.Text = $"{amount_8}/{max_8_amount}";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (amount_9 < max_9_amount)
            {
                amount_9++;
                label9.Text = $"{amount_9}/{max_9_amount}";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (amount_10 < max_10_amount)
            {
                amount_10++;
                label10.Text = $"{amount_10}/{max_10_amount}";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (amount_11 < max_11_amount)
            {
                amount_11++;
                label11.Text = $"{amount_11}/{max_11_amount}";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (amount_12 < max_12_amount)
            {
                amount_12++;
                label12.Text = $"{amount_12}/{max_12_amount}";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (amount_13 < max_13_amount)
            {
                amount_13++;
                label13.Text = $"{amount_13}/{max_13_amount}";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (amount_14 < max_14_amount)
            {
                amount_14++;
                label14.Text = $"{amount_14}/{max_14_amount}";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (amount_15 < max_15_amount)
            {
                amount_15++;
                label15.Text = $"{amount_15}/{max_15_amount}";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (amount_16 < max_16_amount)
            {
                amount_16++;
                label16.Text = $"{amount_16}/{max_16_amount}";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (amount_17 < max_17_amount)
            {
                amount_17++;
                label17.Text = $"{amount_17}/{max_17_amount}";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (amount_18 < max_18_amount)
            {
                amount_18++;
                label18.Text = $"{amount_18}/{max_18_amount}";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (amount_19 < max_19_amount)
            {
                amount_19++;
                label19.Text = $"{amount_19}/{max_19_amount}";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (amount_20 < max_20_amount)
            {
                amount_20++;
                label20.Text = $"{amount_20}/{max_20_amount}";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (amount_21 < max_21_amount)
            {
                amount_21++;
                label21.Text = $"{amount_21}/{max_21_amount}";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (amount_22 < max_22_amount)
            {
                amount_22++;
                label22.Text = $"{amount_22}/{max_22_amount}";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (amount_23 < max_23_amount)
            {
                amount_23++;
                label23.Text = $"{amount_23}/{max_23_amount}";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (amount_24 < max_24_amount)
            {
                amount_24++;
                label24.Text = $"{amount_24}/{max_24_amount}";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (amount_25 < max_25_amount)
            {
                amount_25++;
                label25.Text = $"{amount_25}/{max_25_amount}";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (amount_26 < max_26_amount)
            {
                amount_26++;
                label26.Text = $"{amount_26}/{max_26_amount}";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (amount_27 < max_27_amount)
            {
                amount_27++;
                label27.Text = $"{amount_27}/{max_27_amount}";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (amount_28 < max_28_amount)
            {
                amount_28++;
                label28.Text = $"{amount_28}/{max_28_amount}";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (amount_29 < max_29_amount)
            {
                amount_29++;
                label29.Text = $"{amount_29}/{max_29_amount}";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (amount_30 < max_30_amount)
            {
                amount_30++;
                label30.Text = $"{amount_30}/{max_30_amount}";
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (amount_31 < max_31_amount)
            {
                amount_31++;
                label31.Text = $"{amount_31}/{max_31_amount}";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (amount_32 < max_32_amount)
            {
                amount_32++;
                label32.Text = $"{amount_32}/{max_32_amount}";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (amount_33 < max_33_amount)
            {
                amount_33++;
                label33.Text = $"{amount_33}/{max_33_amount}";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (amount_34 < max_34_amount)
            {
                amount_34++;
                label34.Text = $"{amount_34}/{max_34_amount}";
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (amount_35 < max_35_amount)
            {
                amount_35++;
                label35.Text = $"{amount_35}/{max_35_amount}";
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (amount_36 < max_36_amount)
            {
                amount_36++;
                label36.Text = $"{amount_36}/{max_36_amount}";
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (amount_37 < max_37_amount)
            {
                amount_37++;
                label37.Text = $"{amount_37}/{max_37_amount}";
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (amount_38 < max_38_amount)
            {
                amount_38++;
                label38.Text = $"{amount_38}/{max_38_amount}";
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (amount_39 < max_39_amount)
            {
                amount_39++;
                label39.Text = $"{amount_39}/{max_39_amount}";
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (amount_40 < max_40_amount)
            {
                amount_40++;
                label40.Text = $"{amount_40}/{max_40_amount}";
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (amount_41 < max_41_amount)
            {
                amount_41++;
                label41.Text = $"{amount_41}/{max_41_amount}";
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (amount_42 < max_42_amount)
            {
                amount_42++;
                label42.Text = $"{amount_42}/{max_42_amount}";
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (amount_43 < max_43_amount)
            {
                amount_43++;
                label43.Text = $"{amount_43}/{max_43_amount}";
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (amount_44 < max_44_amount)
            {
                amount_44++;
                label44.Text = $"{amount_44}/{max_44_amount}";
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (amount_45 < max_45_amount)
            {
                amount_45++;
                label45.Text = $"{amount_45}/{max_45_amount}";
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (amount_46 < max_46_amount)
            {
                amount_46++;
                label46.Text = $"{amount_46}/{max_46_amount}";
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (amount_47 < max_47_amount)
            {
                amount_47++;
                label47.Text = $"{amount_47}/{max_47_amount}";
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (amount_48 < max_48_amount)
            {
                amount_48++;
                label48.Text = $"{amount_48}/{max_48_amount}";
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (amount_49 < max_49_amount)
            {
                amount_49++;
                label49.Text = $"{amount_49}/{max_49_amount}";
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (amount_50 < max_50_amount)
            {
                amount_50++;
                label50.Text = $"{amount_50}/{max_50_amount}";
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (amount_51 < max_51_amount)
            {
                amount_51++;
                label51.Text = $"{amount_51}/{max_51_amount}";
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (amount_52 < max_52_amount)
            {
                amount_52++;
                label52.Text = $"{amount_52}/{max_52_amount}";
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (amount_53 < max_53_amount)
            {
                amount_53++;
                label53.Text = $"{amount_53}/{max_53_amount}";
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (amount_54 < max_54_amount)
            {
                amount_54++;
                label54.Text = $"{amount_54}/{max_54_amount}";
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (amount_55 < max_55_amount)
            {
                amount_55++;
                label55.Text = $"{amount_55}/{max_55_amount}";
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (amount_56 < max_56_amount)
            {
                amount_56++;
                label56.Text = $"{amount_56}/{max_56_amount}";
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (amount_57 < max_57_amount)
            {
                amount_57++;
                label57.Text = $"{amount_57}/{max_57_amount}";
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (amount_58 < max_58_amount)
            {
                amount_58++;
                label58.Text = $"{amount_58}/{max_58_amount}";
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (amount_59 < max_59_amount)
            {
                amount_59++;
                label59.Text = $"{amount_59}/{max_59_amount}";
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (amount_60 < max_60_amount)
            {
                amount_60++;
                label60.Text = $"{amount_60}/{max_60_amount}";
            }
        }

        private void button_next_page_Click(object sender, EventArgs e)
        {
            calculations_page2 form_calculations_2 = new calculations_page2();
            form_calculations_2.Show();
        }

        private void calculations_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (amount_1 != 0)
            {
                Form1.amounts.Add($"Added {amount_1} FROM ALISERYL");
            }
            if (amount_2 != 0)
            {
                Form1.amounts.Add($"Added {amount_2} FROM Albendazole Bolus 600mg");
            }
            if (amount_3 != 0)
            {
                Form1.amounts.Add($"Added {amount_3} FROM Albenzole Oral Suspension 10%;LTR");
            }
            if (amount_4 != 0)
            {
                Form1.amounts.Add($"Added {amount_4} FROM Ancesol Inj./ANTI-STAMIN;VIAL/100ML");
            }
            if (amount_5 != 0)
            {
                Form1.amounts.Add($"Added {amount_5} FROM Antihem / Vitamin k3 Injection;20ml/vial");
            }
            if (amount_6 != 0)
            {
                Form1.amounts.Add($"Added {amount_6} FROM Aspivet-C / FIBRINA-C;100g");
            }
            if (amount_7 != 0)
            {
                Form1.amounts.Add($"Added {amount_7} FROM Atropine Sulphate;VIAL");
            }
            if (amount_8 != 0)
            {
                Form1.amounts.Add($"Added {amount_8} FROM Autoclave Tape Indicator");
            }
            if (amount_9 != 0)
            {
                Form1.amounts.Add($"Added {amount_9} FROM Bandage Gauze 36 InchX 100 Yards;Roll");
            }
            if (amount_10 != 0)
            {
                Form1.amounts.Add($"Added {amount_10} FROM Bloat Dad 100 ml;BOT.");
            }
            if (amount_11 != 0)
            {
                Form1.amounts.Add($"Added {amount_11} FROM Buparvon Injection;VIAL/50ML");
            }
            if (amount_12 != 0)
            {
                Form1.amounts.Add($"Added {amount_12} FROM CALVING ROPE WITH LOOP(S);PCS");
            }
            if (amount_13 != 0)
            {
                Form1.amounts.Add($"Added {amount_13} FROM CCPP Vaccine;DOSE");
            }
            if (amount_14 != 0)
            {
                Form1.amounts.Add($"Added {amount_14} FROM Calcium Borogluconate 500ml");
            }
            if (amount_15 != 0)
            {
                Form1.amounts.Add($"Added {amount_15} FROM Calfos tonic / VMD-Oligovit Plus Powder");
            }
            if (amount_16 != 0)
            {
                Form1.amounts.Add($"Added {amount_16} FROM Ceftiofur  50mg/ml;100ML");
            }
            if (amount_17 != 0)
            {
                Form1.amounts.Add($"Added {amount_17} FROM Cetosin lamons / Keto Stop;LTR");
            }
            if (amount_18 != 0)
            {
                Form1.amounts.Add($"Added {amount_18} FROM Ciplacin / Sulphacin Bolus 20s;BOX");
            }
            if (amount_19 != 0)
            {
                Form1.amounts.Add($"Added {amount_19} FROM Cloprostenol 250 microgram/ml");
            }
            if (amount_20 != 0)
            {
                Form1.amounts.Add($"Added {amount_20} FROM DISP. COVERALLS 2XL;PIC");
            }
            if (amount_21 != 0)
            {
                Form1.amounts.Add($"Added {amount_21} FROM DISP. COVERALLS XL;PCS");
            }
            if (amount_22 != 0)
            {
                Form1.amounts.Add($"Added {amount_22} FROM DISP. SYRINGE 20ML 50s;BOX");
            }
            if (amount_23 != 0)
            {
                Form1.amounts.Add($"Added {amount_23} FROM DOXIN-200 WS / TYLODOX  100G;SACH");
            }
            if (amount_24 != 0)
            {
                Form1.amounts.Add($"Added {amount_24} FROM Dexamethasone 2 mg/ 1ml");
            }
            if (amount_25 != 0)
            {
                Form1.amounts.Add($"Added {amount_25} FROM Dextrose 5% BP;BOT.");
            }
            if (amount_26 != 0)
            {
                Form1.amounts.Add($"Added {amount_26} FROM Dextrose 5% in  Normal Saline;500 ML");
            }
            if (amount_27 != 0)
            {
                Form1.amounts.Add($"Added {amount_27} FROM Diakur Plus/NUTRIVET PR;SACH");
            }
            if (amount_28 != 0)
            {
                Form1.amounts.Add($"Added {amount_28} FROM Disposable Hooded Coverall Waterproof size : 2XL;PIECE.");
            }
            if (amount_29 != 0)
            {
                Form1.amounts.Add($"Added {amount_29} FROM Disposable Hooded Coverall Waterproof size : XL;PIECE.");
            }
            if (amount_30 != 0)
            {
                Form1.amounts.Add($"Added {amount_30} FROM Disposable Hypodermic Needles 18GX1/2\";BOX.\"");
            }
            if (amount_31 != 0)
            {
                Form1.amounts.Add($"Added {amount_31} FROM Disposable Infusion Set / Sterile;PCS.");
            }
            if (amount_32 != 0)
            {
                Form1.amounts.Add($"Added {amount_32} FROM Disposable syring 5ML 100/BOX;SYRINGE");
            }
            if (amount_33 != 0)
            {
                Form1.amounts.Add($"Added {amount_33} FROM Disposable syring 10 ML");
            }
            if (amount_34 != 0)
            {
                Form1.amounts.Add($"Added {amount_34} FROM Doramectin[10 mg /1 ml]");
            }
            if (amount_35 != 0)
            {
                Form1.amounts.Add($"Added {amount_35} FROM Duphalyte 500 ML;BOT.");
            }
            if (amount_36 != 0)
            {
                Form1.amounts.Add($"Added {amount_36} FROM E-Selen Powder;100g/SACS");
            }
            if (amount_37 != 0)
            {
                Form1.amounts.Add($"Added {amount_37} FROM Emasco / Vitaminera/Protevit;Bottle.");
            }
            if (amount_38 != 0)
            {
                Form1.amounts.Add($"Added {amount_38} FROM Enrofloxacin Oral  100MG 1L;Bottle.");
            }
            if (amount_39 != 0)
            {
                Form1.amounts.Add($"Added {amount_39} FROM Enzivet Inj.;VIAL.");
            }
            if (amount_40 != 0)
            {
                Form1.amounts.Add($"Added {amount_40} FROM Enzymofarco;Bottle.");
            }
            if (amount_41 != 0)
            {
                Form1.amounts.Add($"Added {amount_41} FROM FMD vaccine 300ml - 300dose;DOSE.");
            }
            if (amount_42 != 0)
            {
                Form1.amounts.Add($"Added {amount_42} FROM FUROSEMIDE 5% 50ML.");
            }
            if (amount_43 != 0)
            {
                Form1.amounts.Add($"Added {amount_43} FROM Flogiderm Powder;SACH.");
            }
            if (amount_44 != 0)
            {
                Form1.amounts.Add($"Added {amount_44} FROM Florfenicol Injection;VIAL.");
            }
            if (amount_45 != 0)
            {
                Form1.amounts.Add($"Added {amount_45} FROM Flunixin Meglumine 50mg/ml 100ml.");
            }
            if (amount_46 != 0)
            {
                Form1.amounts.Add($"Added {amount_46} FROM GAUZE BANDAGE 10cm X 6 yds;Roll.");
            }
            if (amount_47 != 0)
            {
                Form1.amounts.Add($"Added {amount_47} FROM GLASS BARREL 50 cc;PCS.");
            }
            if (amount_48 != 0)
            {
                Form1.amounts.Add($"Added {amount_48} FROM GPC8 / Aldekol DES 25 / Agrigerm 1510;GAL.");
            }
            if (amount_49 != 0)
            {
                Form1.amounts.Add($"Added {amount_49} FROM GYPSONA  PLASTER;Roll.");
            }
            if (amount_50 != 0)
            {
                Form1.amounts.Add($"Added {amount_50} FROM Gemicin Spray;BOT/250ML.");
            }
            if (amount_51 != 0)
            {
                Form1.amounts.Add($"Added {amount_51} FROM Herbal Wound Cream;JAR.");
            }
            if (amount_52 != 0)
            {
                Form1.amounts.Add($"Added {amount_52} FROM Hydrogen Peroxide ");
            }
            if (amount_53 != 0)
            {
                Form1.amounts.Add($"Added {amount_53} FROM Hypermineral Plus Solution;Bottle.");
            }
            if (amount_54 != 0)
            {
                Form1.amounts.Add($"Added {amount_54} FROM ICE BOX 36 Liter;PCS.");
            }
            if (amount_55 != 0)
            {
                Form1.amounts.Add($"Added {amount_55} FROM Imidocarb-LH / IMIZOL;VIAL.");
            }
            if (amount_56 != 0)
            {
                Form1.amounts.Add($"Added {amount_56} FROM Irol Inj. 100ml;VIAL.");
            }
            if (amount_57 != 0)
            {
                Form1.amounts.Add($"Added {amount_57} FROM Ivermectin 10 mg/ml  Vial.");
            }
            if (amount_58 != 0)
            {
                Form1.amounts.Add($"Added {amount_58} FROM Ketoprofen[100 mg / 1 ml]");
            }
            if (amount_59 != 0)
            {
                Form1.amounts.Add($"Added {amount_59} FROM LONG GLOVES;BOX");
            }
            if (amount_60 != 0)
            {
                Form1.amounts.Add($"Added {amount_60} FROM Laboratory Eye Wash Solution 1 Piece/Pack");
            }




            Settings.Default.max1 = max_1_amount - amount_1;
            Settings.Default.max2 = max_2_amount - amount_2;
            Settings.Default.max3 = max_3_amount - amount_3;
            Settings.Default.max4 = max_4_amount - amount_4;
            Settings.Default.max5 = max_5_amount - amount_5;
            Settings.Default.max6 = max_6_amount - amount_6;
            Settings.Default.max7 = max_7_amount - amount_7;
            Settings.Default.max8 = max_8_amount - amount_8;
            Settings.Default.max9 = max_9_amount - amount_9;
            Settings.Default.max10 = max_10_amount - amount_10;
            Settings.Default.max11 = max_11_amount - amount_11;
            Settings.Default.max12 = max_12_amount - amount_12;
            Settings.Default.max13 = max_13_amount - amount_13;
            Settings.Default.max14 = max_14_amount - amount_14;
            Settings.Default.max15 = max_15_amount - amount_15;
            Settings.Default.max16 = max_16_amount - amount_16;
            Settings.Default.max17 = max_17_amount - amount_17;
            Settings.Default.max18 = max_18_amount - amount_18;
            Settings.Default.max19 = max_19_amount - amount_19;
            Settings.Default.max20 = max_20_amount - amount_20;
            Settings.Default.max21 = max_21_amount - amount_21;
            Settings.Default.max22 = max_22_amount - amount_22;
            Settings.Default.max23 = max_23_amount - amount_23;
            Settings.Default.max24 = max_24_amount - amount_24;
            Settings.Default.max25 = max_25_amount - amount_25;
            Settings.Default.max26 = max_26_amount - amount_26;
            Settings.Default.max27 = max_27_amount - amount_27;
            Settings.Default.max28 = max_28_amount - amount_28;
            Settings.Default.max29 = max_29_amount - amount_29;
            Settings.Default.max30 = max_30_amount - amount_30;
            Settings.Default.max31 = max_31_amount - amount_31;
            Settings.Default.max32 = max_32_amount - amount_32;
            Settings.Default.max33 = max_33_amount - amount_33;
            Settings.Default.max34 = max_34_amount - amount_34;
            Settings.Default.max35 = max_35_amount - amount_35;
            Settings.Default.max36 = max_36_amount - amount_36;
            Settings.Default.max37 = max_37_amount - amount_37;
            Settings.Default.max38 = max_38_amount - amount_38;
            Settings.Default.max39 = max_39_amount - amount_39;
            Settings.Default.max40 = max_40_amount - amount_40;
            Settings.Default.max41 = max_41_amount - amount_41;
            Settings.Default.max42 = max_42_amount - amount_42;
            Settings.Default.max43 = max_43_amount - amount_43;
            Settings.Default.max44 = max_44_amount - amount_44;
            Settings.Default.max45 = max_45_amount - amount_45;
            Settings.Default.max46 = max_46_amount - amount_46;
            Settings.Default.max47 = max_47_amount - amount_47;
            Settings.Default.max48 = max_48_amount - amount_48;
            Settings.Default.max49 = max_49_amount - amount_49;
            Settings.Default.max50 = max_50_amount - amount_50;
            Settings.Default.max51 = max_51_amount - amount_51;
            Settings.Default.max52 = max_52_amount - amount_52;
            Settings.Default.max53 = max_53_amount - amount_53;
            Settings.Default.max54 = max_54_amount - amount_54;
            Settings.Default.max55 = max_55_amount - amount_55;
            Settings.Default.max56 = max_56_amount - amount_56;
            Settings.Default.max57 = max_57_amount - amount_57;
            Settings.Default.max58 = max_58_amount - amount_58;
            Settings.Default.max59 = max_59_amount - amount_59;
            Settings.Default.max60 = max_60_amount - amount_60;
            
            Settings.Default.Save();
            amount_1 = 0;
            
            
        }

        private void calculations_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }
    }

}
