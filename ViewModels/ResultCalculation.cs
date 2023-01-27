using QuadraticInequalities.Models;
using System.Text;

namespace QuadraticInequalities.ViewModels
{
    public class ResultCalculation
    {
        public static string CalculateResult(Inequality inequality)
        {
            StringBuilder StringBuilder = new StringBuilder();
            if (inequality.A != 0)
            {
                if (inequality.Discriminant < 0)
                {
                    if (inequality.Symbol == ">=" || inequality.Symbol == ">")
                    {
                        if (inequality.A > 0)
                        {
                            return "x należy do liczb rzeczywistych";
                        }
                        else
                        {
                            return "brak rozwiązań dla liczb rzeczywistych";
                        }
                    }
                    else
                    {
                        if (inequality.A < 0)
                        {
                            return "brak rozwiązań dla liczb rzeczywistych";
                        }
                        else
                        {
                            return "x należy do liczb rzeczywistych";
                        }
                    }
                }
                else if (inequality.Discriminant == 0)
                {
                    if (inequality.Symbol == ">=")
                    {
                        if (inequality.A > 0)
                        {
                            return "x należy do liczb rzeczywistych";
                        }
                        else
                        {
                            return $"x = {inequality.X1}";
                        }
                    }
                    else if (inequality.Symbol == ">")
                    {
                        if (inequality.A > 0)
                        {
                            return $"x należy do liczb rzeczywistych poza {inequality.X1}";
                        }
                        else
                        {
                            return $"brak rozwiązań dla liczb rzeczywistych";
                        }
                    }
                    else if (inequality.Symbol == "<=")
                    {
                        if (inequality.A > 0)
                        {
                            return $"x = {inequality.X1}";
                        }
                        else
                        {
                            return $"x należy do liczb rzeczywistych";
                        }
                    }
                    else
                    {
                        if (inequality.A < 0)
                        {
                            return "brak rozwiązań dla liczb rzeczywistych";
                        }
                        else
                        {
                            return $"x należy do liczb rzeczywistych poza {inequality.X1}";
                        }
                    }
                }
                else
                {
                    if (inequality.Symbol == ">=")
                    {
                        if (inequality.A > 0)
                        {
                            return "x należy do liczb rzeczywistych";
                        }
                        else
                        {
                            return $"x = {inequality.X1}";
                        }
                    }
                    else if (inequality.Symbol == ">")
                    {
                        if (inequality.A > 0)
                        {
                            return $"x należy do liczb rzeczywistych poza {inequality.X1}";
                        }
                        else
                        {
                            return $"brak rozwiązań dla liczb rzeczywistych";
                        }
                    }
                    else if (inequality.Symbol == "<=")
                    {
                        if (inequality.A > 0)
                        {
                            return $"x = {inequality.X1}";
                        }
                        else
                        {
                            return $"x należy do liczb rzeczywistych";
                        }
                    }
                    else
                    {
                        if (inequality.A < 0)
                        {
                            return "brak rozwiązań dla liczb rzeczywistych";
                        }
                        else
                        {
                            return $"x należy do liczb rzeczywistych poza {inequality.X1}";
                        }
                    }
                }
            }

            return StringBuilder.ToString();
        }
    }
}