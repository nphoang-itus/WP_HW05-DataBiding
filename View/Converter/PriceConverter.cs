using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataBiding.View.Converter
{
    public class PriceConverter : IValueConverter
    {
        public string CultureName { get; set; } = "vi-VN";

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null) return "";

            try
            {
                // Chuyển giá trị sang dạng số
                if (decimal.TryParse(value.ToString(), out decimal price))
                {
                    string formatted = string.Format(new CultureInfo(CultureName), "{0:N0}", price);
                    if (CultureName == "en-US")
                    {
                        return $"{"$"}{formatted}";
                    }

                    return $"{formatted} {"đ"}";
                }
                else
                {
                    return value.ToString();
                }
            }
            catch
            {
                return value.ToString();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
