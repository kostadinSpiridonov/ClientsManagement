using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace ClientsManagment.Validation
{
    public class Validator
    {
        public static bool ValidateModel<T>(T item)
        {
            bool isValid = true;
            var typeInfo = item.GetType();
            var properties = typeInfo.GetRuntimeProperties();

            foreach (var property in properties)
            {
                bool isValidatableField = property.PropertyType.IsConstructedGenericType &&
                    property.PropertyType.GetGenericTypeDefinition() == typeof(ValidatableField<>);

                if (isValidatableField)
                {
                    dynamic field = property.GetValue(item);
                    if (field != null)
                    {
                        field.Errors.Clear();

                        var attributes = property.GetCustomAttributes(true);
                        foreach (var attribute in attributes)
                        {
                            var attributeInstance = attribute as ValidationAttribute;
                            if (attributeInstance != null && !attributeInstance.IsValid(field.Value))
                            {
                                isValid = false;
                                field.Errors.Add(attributeInstance.ErrorMessage);
                            }
                        }
                    }
                }
            }

            return isValid;
        }

        public static bool ValidateProperty<T>(T item, string propertyName)
        {
            bool isValid = true;
            var typeInfo = item.GetType();
            var property = typeInfo
                .GetRuntimeProperties()
                .FirstOrDefault(x => x.Name == propertyName);

            bool isValidatableField = property.PropertyType.IsConstructedGenericType &&
                property.PropertyType.GetGenericTypeDefinition() == typeof(ValidatableField<>);

            if (isValidatableField)
            {
                dynamic field = property.GetValue(item);
                if (field != null)
                {
                    field.Errors.Clear();

                    var attributes = property.GetCustomAttributes(true);
                    foreach (var attribute in attributes)
                    {
                        var attributeInstance = attribute as ValidationAttribute;
                        if (attributeInstance != null && !attributeInstance.IsValid(field.Value))
                        {
                            isValid = false;
                            field.Errors.Add(attributeInstance.ErrorMessage);
                        }
                    }
                }
            }

            return isValid;
        }
    }
}