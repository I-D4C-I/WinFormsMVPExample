using System.ComponentModel.DataAnnotations;
using WinFormsWPFExample.Models;

namespace WinFormsWPFExample.Repositories.Common
{
    /// <summary>
    /// Представляет класс для валидации данных модели питомца.
    /// </summary>
    internal class ModelDataValidation
    {
        /// <summary>
        /// Проверяет корректность данных модели питомца.
        /// </summary>
        /// <param name="model">Модель питомца для валидации.</param>
        public static void Validate(PetModel model)
        {
            string errorMessage = string.Empty;
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);

            bool isValid = Validator.TryValidateObject(model, context, results, true);

            // Если данные некорректны, формируется сообщение об ошибке.
            if (!isValid)
            {
                foreach (var result in results)
                    errorMessage += "- " + result.ErrorMessage + "\n";

                throw new Exception(errorMessage);
            }
        }
    }
}
