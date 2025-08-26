# Properties in C#
- to access private members of class from outside
- Encapsulation - private

## Special methods -> Accessors
- Set: 
 - is used to set the values
- get:
 - is used to retrieve the values

## Types of properties: 
- Read-write property
- Read only property 
- write only propery
- Auto implemented property


# 📌 C# Properties – Short Notes

## 🔹 Basics
- Properties provide **controlled access** to class fields.  
- `get` → used to **read** value.  
- `set` → used to **write** value (`value` keyword holds assigned data).  

---

## 🔹 Types of Properties with Examples

### 1. **Read-Write Property**
```csharp
class Student
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Dharmraj";       // set
        Console.WriteLine(s.Name); // get
    }
}
````

---

### 2. **Read-Only Property**

```csharp
class Student
{
    private int rollNo;
    public Student(int r) { rollNo = r; }
    public int RollNo   // only get
    {
        get { return rollNo; }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student(101);
        Console.WriteLine(s.RollNo); // ✅ works
        // s.RollNo = 200; ❌ error (no set)
    }
}
```

---

### 3. **Write-Only Property**

```csharp
class Secret
{
    private string password;
    public string Password   // only set
    {
        set { password = value; }
    }

    public void ShowPassword()
    {
        Console.WriteLine(password);
    }
}

class Program
{
    static void Main()
    {
        Secret s = new Secret();
        s.Password = "12345";  // ✅ works
        // Console.WriteLine(s.Password); ❌ error
        s.ShowPassword();      // but accessible inside class
    }
}
```

---

### 4. **Auto-Implemented Property**

```csharp
class Student
{
    public string Name { get; set; }   // read-write
    public int RollNo { get; }         // read-only (set in ctor)

    public Student(int r)
    {
        RollNo = r;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student(101);
        s.Name = "Veer";
        Console.WriteLine(s.Name);   // ✅
        Console.WriteLine(s.RollNo); // ✅
    }
}
```

---

## 🔹 Quick Summary Table

| Property Type    | get | set | Example Syntax               |
| ---------------- | --- | --- | ---------------------------- |
| Read-Write       | ✅   | ✅   | `public int X { get; set; }` |
| Read-Only        | ✅   | ❌   | `public int X { get; }`      |
| Write-Only       | ❌   | ✅   | `public int X { set; }`      |
| Auto-Implemented | ✅   | ✅   | `public int X { get; set; }` |

---

