using ReflectionWithIValidatable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Car : Attribute, IValidatable
{
    [StringLength(10, MinimumLength = 1)]
    public string Name { get; set; }

    [Range(1, 4500)]
    public double HorsePower { get; set; }
    [Range(1, 50)]
    public double Racing { get; set; }

    public Car(string carName, int hpCar, double racing)
    {
        Name = carName;
        HorsePower = hpCar;
        Racing = racing;
    }
    public Car()
    {

    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (this.Name == null)
        {
            yield return new ValidationResult("Строка пустая", new[] { "Name" });
        }

        yield break;
    }
}