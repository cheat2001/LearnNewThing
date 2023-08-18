# Couplers
## 1. Feature Envy
#### Definition: <b> Feature Envy </b> is a code smell that occurs when a method or function in one class uses more methods, properties, or data from another class than from its own class. In other words, the method seems more interested in the internals of another class rather than the class it belongs to.
## Example-1
### <b>Smelly</b>
```csharp
class Course
{
    public string CourseName { get; set; }
    public int CourseDuration { get; set; }
}

class Student
{
    public string Name { get; set; }
    public Course EnrolledCourse { get; set; }

    public string GetCourseInfo()
    {
        // Feature Envy: The Student class is too interested in Course details.
        return "Course: " + EnrolledCourse.CourseName + ", Duration: " + EnrolledCourse.CourseDuration + " hours";
    }
}

```


### <b>Solution </b>

```csharp
class Course{
  public string CourseName{get;set}
  public int CourseDuration{get;set;}

  public string GetCourseInfo(){
   return "Course: "+ CourseName+ "Duration: " + "CourseDuration";
  }

}

class Student{
  public string Name{get;set;}
  public Course EnrolledCourse{get;set;}
}

```

## Example-2
### <b>Smelly</b>
```csharp
class Dog
{
    public string Name { get; set; }
    public bool IsFriendly { get; set; }
}

class Person
{
    public string Name { get; set; }
    public Dog Pet { get; set; }

    public string GetPetInfo()
    {
        // Feature Envy: Person class is too interested in Dog class's behavior.
        if (Pet.IsFriendly)
            return "Your pet is friendly!";
        else
            return "Your pet is not friendly.";
    }
}


```


### <b>Solution </b>

```csharp
class Dog
{
    public string Name { get; set; }
    public bool IsFriendly { get; set; }

    public string GetFriendlinessInfo()
    {
        if (IsFriendly)
            return "Friendly";
        else
            return "Not friendly";
    }
}

class Person
{
    public string Name { get; set; }
    public Dog Pet { get; set; }
}

```


### Refactoring:
- Move Method
- Move Field
- Extract Method.

### => Playoff/Benefit:

- Less code duplication (if the data handling code is put in a central place)
- Better code organization (methods for handling data are next to the actual data)

