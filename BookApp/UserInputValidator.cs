using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public static class UserInputValidator
    {
        public static bool ValidateMenuChoice(string input, int numberOfWelcomeMenuOptions)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return false;
                }
                else if (int.Parse(input) < 1)
                {
                    return false;
                }
                else if (int.Parse(input) > numberOfWelcomeMenuOptions)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool ValidateBookTitleOrAuthorInput(string input)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return false;
                }
                else if (input.Any(ch => char.IsDigit(ch) || char.IsSymbol(ch)))
                {
                    return false;
                }
                else if (input.Length > 50)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool ValidateIsbn(string input)
        {
            if (input.Contains("-"))
            {
                input = input.Replace("-", "");
            }
            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return false;
                }
                else if (input.Any(ch => !char.IsDigit(ch)))
                {
                    return false;
                }
                else if (input.Length > 50 || input.Length < 10)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool ValidateQuantity(string amount)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(amount))
                {
                    return false;
                }
                else if (int.Parse(amount) < 0)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool ValidateQuantityToUpdateStock(string amount)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(amount))
                {
                    return false;
                }
                //else if (int.Parse(amount) < 0)
                //{
                //    return false;
                //}
            }
            catch
            {
                return false;
            }

            return true;
        }


    }
}
