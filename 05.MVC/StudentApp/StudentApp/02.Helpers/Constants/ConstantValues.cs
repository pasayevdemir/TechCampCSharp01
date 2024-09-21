namespace Helpers.Constants
{
    public class ConstantValues
    {
        public readonly static int DEFAULT_PRIMARY_KEY = 100;
        public readonly static string DEFAULT_DELETED_COLUMN_VALUE = "0";
        public readonly static string DO_NOT_EMPTY_FIELDS = "Sahələr boş ola bilməz!";

        public static string NotNullOrEmpty(string columnName)
        {
                return $"'{columnName}' sahəsi boş buraxıla bilməz!";
        }
        public static string HasMaxLength(string columnName, int maxValue)
        {
            return $"{columnName} {maxValue} sivoldan çox ola bilməz!";
        }
        public static string HasMinLength(string columnName, int minValue)
        {
            return $"{columnName} {minValue} sivoldan az ola bilməz!";
        }
    }
}
