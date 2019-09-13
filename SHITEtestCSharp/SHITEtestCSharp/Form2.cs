using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHITEtestCSharp
{
    public class FemaleTest:Form
    {

        private void CmdClose_Click(object sender, EventArgs e)
        {
            string confirm;
            confirm = MsgBox("Are you sure you want to cancel the SHITE test?", vbYesNo);
            if ((confirm == System.Windows.Forms.MessageBoxButtons.Yes))
            {
                this.Close();
                SHITEmenu.Show();
            }

        }

        private void Test_Load(object sender, EventArgs e)
        {
        }

        private void CBQ1yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ1no.CheckState == CheckState.Checked))
            {
                CBQ1no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ1no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ1yes.CheckState == CheckState.Checked))
            {
                CBQ1yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ2yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ2no.CheckState == CheckState.Checked))
            {
                CBQ2no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ2no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ2yes.CheckState == CheckState.Checked))
            {
                CBQ2yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ3yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ3no.CheckState == CheckState.Checked))
            {
                CBQ3no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ3no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ3yes.CheckState == CheckState.Checked))
            {
                CBQ3yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ4yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ4no.CheckState == CheckState.Checked))
            {
                CBQ4no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ4no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ4yes.CheckState == CheckState.Checked))
            {
                CBQ4yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ5yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ5no.CheckState == CheckState.Checked))
            {
                CBQ5no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ5no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ5yes.CheckState == CheckState.Checked))
            {
                CBQ5yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ6yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ6no.CheckState == CheckState.Checked))
            {
                CBQ6no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ6no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ6yes.CheckState == CheckState.Checked))
            {
                CBQ6yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ7yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ7no.CheckState == CheckState.Checked))
            {
                CBQ7no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ7no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ7yes.CheckState == CheckState.Checked))
            {
                CBQ7yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ8yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ8no.CheckState == CheckState.Checked))
            {
                CBQ8no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ8no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ8yes.CheckState == CheckState.Checked))
            {
                CBQ8yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ9yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ9no.CheckState == CheckState.Checked))
            {
                CBQ9no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ9no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ9yes.CheckState == CheckState.Checked))
            {
                CBQ9yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ10yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ10no.CheckState == CheckState.Checked))
            {
                CBQ10no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ10no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ10yes.CheckState == CheckState.Checked))
            {
                CBQ10yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ11yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ11no.CheckState == CheckState.Checked))
            {
                CBQ11no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ11no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ11yes.CheckState == CheckState.Checked))
            {
                CBQ11yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ12yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ12no.CheckState == CheckState.Checked))
            {
                CBQ12no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ12no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ12yes.CheckState == CheckState.Checked))
            {
                CBQ12yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ13yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ13no.CheckState == CheckState.Checked))
            {
                CBQ13no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ13no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ13yes.CheckState == CheckState.Checked))
            {
                CBQ13yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ14yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ14no.CheckState == CheckState.Checked))
            {
                CBQ14no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ14no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ14yes.CheckState == CheckState.Checked))
            {
                CBQ14yes.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ15yes_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ15no.CheckState == CheckState.Checked))
            {
                CBQ15no.CheckState = CheckState.Unchecked;
            }

        }

        private void CBQ15no_CheckedChanged(object sender, EventArgs e)
        {
            if ((CBQ15yes.CheckState == CheckState.Checked))
            {
                CBQ15yes.CheckState = CheckState.Unchecked;
            }

        }

        public int Score = 0;

        private void CmdCheck_Click_1(object sender, EventArgs e)
        {
            if ((CBQ1yes.CheckState == CheckState.Checked))
            {
                Score = (Score + 10);
            }

            if ((CBQ2yes.CheckState == CheckState.Checked))
            {
                Score = (Score + 20);
            }

            if ((CBQ3yes.CheckState == CheckState.Checked))
            {
                Score = 20;
                Score = 20;
            }

            if ((CBQ4yes.CheckState == CheckState.Unchecked))
            {
                Score = 5;
                Score = 5;
            }

            if ((CBQ5yes.CheckState == CheckState.Unchecked))
            {
                Score = 20;
                Score = 20;
            }

            if ((CBQ6yes.CheckState == CheckState.Checked))
            {
                Score = 5;
                Score = 5;
            }

            if ((CBQ7yes.CheckState == CheckState.Unchecked))
            {
                Score = 5;
                Score = 5;
            }

            if ((CBQ8yes.CheckState == CheckState.Checked))
            {
                Score = 5;
                Score = 5;
            }

            if ((CBQ9yes.CheckState == CheckState.Unchecked))
            {
                Score = 5;
                Score = 5;
            }

            if ((CBQ10yes.CheckState == CheckState.Checked))
            {
                Score = 15;
                Score = 15;
            }

            if ((CBQ11yes.CheckState == CheckState.Unchecked))
            {
                Score = 5;
                Score = 5;
            }

            if ((CBQ12yes.CheckState == CheckState.Checked))
            {
                Score = 5;
                Score = 5;
            }

            if ((CBQ13yes.CheckState == CheckState.Unchecked))
            {
                Score = (Score + 10);
            }

            if ((CBQ14yes.CheckState == CheckState.Checked))
            {
                Score = (Score + 10);
            }

            if ((CBQ15yes.CheckState == CheckState.Checked))
            {
                Score = (Score + 10);
            }

            SHITEmenu.LBLScored.Text = "";
            Your;
            previous;
            score;
            the;
            SHITE;
            test;
        was:
            " & Scor";
            if ((Score > 0))
            {
                if ((CBQ1yes.Checked || CBQ1no.Checked))
                {
                    if ((CBQ2yes.Checked || CBQ2no.Checked))
                    {
                        if ((CBQ3yes.Checked || CBQ3no.Checked))
                        {
                            if ((CBQ4yes.Checked || CBQ4no.Checked))
                            {
                                if ((CBQ5yes.Checked || CBQ5no.Checked))
                                {
                                    if ((CBQ6yes.Checked || CBQ6no.Checked))
                                    {
                                        if ((CBQ7yes.Checked || CBQ7no.Checked))
                                        {
                                            if ((CBQ8yes.Checked || CBQ8no.Checked))
                                            {
                                                if ((CBQ9yes.Checked || CBQ9no.Checked))
                                                {
                                                    if ((CBQ10yes.Checked || CBQ10no.Checked))
                                                    {
                                                        if ((CBQ11yes.Checked || CBQ11no.Checked))
                                                        {
                                                            if ((CBQ12yes.Checked || CBQ12no.Checked))
                                                            {
                                                                if ((CBQ13yes.Checked || CBQ13no.Checked))
                                                                {
                                                                    if ((CBQ14yes.Checked || CBQ14no.Checked))
                                                                    {
                                                                        if ((CBQ15yes.Checked || CBQ15no.Checked))
                                                                        {
                                                                            Results.Show();
                                                                            this.Hide();
                                                                        }
                                                                        else
                                                                        {
                                                                            MsgBox("You didn\'t answer a question");
                                                                        }

                                                                    }
                                                                    else
                                                                    {
                                                                        MsgBox("You didn\'t answer a question");
                                                                    }

                                                                }
                                                                else
                                                                {
                                                                    MsgBox("You didn\'t answer a question");
                                                                }

                                                            }
                                                            else
                                                            {
                                                                MsgBox("You didn\'t answer a question");
                                                            }

                                                        }
                                                        else
                                                        {
                                                            MsgBox("You didn\'t answer a question");
                                                        }

                                                    }
                                                    else
                                                    {
                                                        MsgBox("You didn\'t answer a question");
                                                    }

                                                }
                                                else
                                                {
                                                    MsgBox("You didn\'t answer a question");
                                                }

                                            }
                                            else
                                            {
                                                MsgBox("You didn\'t answer a question");
                                            }

                                        }
                                        else
                                        {
                                            MsgBox("You didn\'t answer a question");
                                        }

                                    }
                                    else
                                    {
                                        MsgBox("You didn\'t answer a question");
                                    }

                                }
                                else
                                {
                                    MsgBox("You didn\'t answer a question");
                                }

                            }
                            else
                            {
                                MsgBox("You didn\'t answer a question");
                            }

                        }
                        else
                        {
                            MsgBox("You didn\'t answer a question");
                        }

                    }
                    else
                    {
                        MsgBox("You didn\'t answer a question");
                    }

                }
                else
                {
                    MsgBox("You didn\'t answer a question");
                }

            }
            else
            {
                MsgBox("You havent selected any boxes!");
            }

        }
    }
