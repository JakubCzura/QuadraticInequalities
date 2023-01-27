using QuadraticInequalities.Models;

namespace QuadraticInequalities.ViewModels
{
    public class ResultCalculation
    {
        /// <summary>
        /// Creates result from given inequality
        /// </summary>
        /// <param name="inequality">Inequality to calculate</param>
        /// <returns>Result from given inequality</returns>
        public static string CalculateResult(Inequality inequality)
        {
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
                            return "x należy do liczb rzeczywistych";
                        }
                        else
                        {
                            return "brak rozwiązań dla liczb rzeczywistych";
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
                            return $"x <= {inequality.X1} lub x >= {inequality.X2}";
                        }
                        else
                        {
                            return $"x >= {inequality.X1} oraz x <= {inequality.X2}";
                        }
                    }
                    else if (inequality.Symbol == ">")
                    {
                        if (inequality.A > 0)
                        {
                            return $"x < {inequality.X1} lub x > {inequality.X2}";
                        }
                        else
                        {
                            return $"x > {inequality.X1} oraz x < {inequality.X2}";
                        }
                    }
                    else if (inequality.Symbol == "<=")
                    {
                        if (inequality.A > 0)
                        {
                            return $"x >= {inequality.X1} oraz x <= {inequality.X2}";
                        }
                        else
                        {
                            return $"x <= {inequality.X1} lub x >= {inequality.X2}";
                        }
                    }
                    else
                    {
                        if (inequality.A < 0)
                        {
                            return $"x < {inequality.X1} lub x > {inequality.X2}";
                        }
                        else
                        {
                            return $"x > {inequality.X1} oraz x < {inequality.X2}";
                        }
                    }
                }
            }
            return "Współczynnik a musi być różny od 0";
        }
    }
}