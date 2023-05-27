using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionWithIValidatable
{
    public static class ValidatorExtensions
    {
        public static IEnumerable<ValidationResult> Validate<T>(this T obj) where T : IValidatable
        {
            // создаем контекст валидации
            var validationContext = new ValidationContext(obj);

            // получаем результаты валидации при помощи System.ComponentModel.DataAnnotations.Validator
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(obj, validationContext, validationResults, true);

            // получаем результаты кастомной валидации
            var customValidationResults = obj.Validate(validationContext);

            // объединяем все результаты валидации
            var results = new List<ValidationResult>(validationResults);
            results.AddRange(customValidationResults);

            return results;
        }
    }
}
