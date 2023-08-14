using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DropDownMvc
{
    public static class EnumExtensions
    {
		public static string? GetDisplayName(this Type type, object value)
        {
            if (type.IsEnum)
            {
				var name = type.GetEnumName(value);
				if (name != null)
				{
					var member = type.GetMember(name);
					if (member.Length > 0)
					{
						var display = member[0].GetCustomAttribute<DisplayAttribute>();
						if (display != null)
							return display.Name;
						return member[0].Name;
					}
				}

			}
			return null;	
		}
	}
}
