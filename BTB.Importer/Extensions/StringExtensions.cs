namespace BTB.Importer.Extensions
{
	public static class StringExtensions
	{
		public static decimal ToDecimal(this string value) =>
			decimal.TryParse(value, out var result) ? result : default;
		public static string ToFirstName(this string value) =>
			value.Split(' ')[0];

		public static string ToLastName(this string value) =>
			value.Split(' ')[1];
	}
}

