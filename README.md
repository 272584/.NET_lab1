# dotNET_lab1
# Problem plecakowy - rozwiązanie i testy

## Opis projektu

Projekt ten dotyczy rozwiązania problemu plecakowego przy użyciu algorytmu zachłannego (greedy algorithm). Celem jest maksymalizacja wartości wybranych przedmiotów, które można pomieścić w plecaku o określonej pojemności. Projekt zawiera aplikację konsolową oraz aplikację z **graficznym interfejsem użytkownika (GUI)** w technologii **Windows Forms**. Dodatkowo, zaimplementowane zostały testy jednostkowe w technologii **MSTest**.

## Struktura projektu

Projekt składa się z dwóch głównych części:

1. **Aplikacja konsolowa** - Zawiera logikę rozwiązującą problem plecakowy. Użytkownik może wprowadzić liczbę przedmiotów, ziarno (seed) do generowania przedmiotów, oraz pojemność plecaka.
2. **GUI (Windows Forms)** - Graficzny interfejs użytkownika, który pozwala na interakcję z aplikacją za pomocą kontrolki **TextBox**, **Button**, i **ListBox**. GUI wyświetla wyniki działania algorytmu.
3. **Testy jednostkowe** - Testy wykonujące operacje na algorytmie rozwiązującym problem plecakowy, w tym testy dla różnych przypadków (np. minimalna pojemność plecaka, pełny plecak).

## Algorytm rozwiązania problemu plecakowego

Algorytm opiera się na zasadzie zachłanności, gdzie przedmioty są sortowane według stosunku **wartość/waga** i wybierane są te, które mają najwyższą wartość na jednostkę wagi. Algorytm kończy działanie, gdy nie można dodać żadnego przedmiotu bez przekroczenia pojemności plecaka.

### Kluczowe klasy:
- **Problem** – Klasa odpowiedzialna za generowanie przedmiotów oraz rozwiązywanie problemu plecakowego przy użyciu algorytmu zachłannego.
- **Item** – Klasa reprezentująca przedmiot w problemie plecakowym, zawierająca wartość, wagę oraz indeks.
- **Result** – Klasa przechowująca wyniki rozwiązania, takie jak wybrane przedmioty, łączna waga i wartość.

## Funkcjonalności

### **1. Aplikacja Konsolowa**
Aplikacja konsolowa umożliwia użytkownikowi:
- Wprowadzenie liczby przedmiotów.
- Wprowadzenie wartości ziarna (seed) do generowania danych wejściowych.
- Wprowadzenie pojemności plecaka.
- Wyświetlenie wyników (wybrane przedmioty, ich łączna waga i wartość).

### **2. GUI (Windows Forms)**
Aplikacja Windows Forms umożliwia użytkownikowi:
- Wprowadzenie danych za pomocą kontrolek **TextBox** (liczba przedmiotów, ziarno, pojemność plecaka).
- Wyświetlanie wyników w kontrolce **TextBox** lub **ListBox**.
- Uruchomienie algorytmu po kliknięciu przycisku **Run**.

### **3. Testy Jednostkowe**
Testy jednostkowe zostały napisane przy użyciu **MSTest**. Testy sprawdzają poprawność algorytmu w różnych scenariuszach:
- **TestNonEmptySolution**: Sprawdza, czy algorytm wybiera przynajmniej jeden przedmiot, gdy pojemność plecaka jest większa niż zero.
- **TestEmptySolution**: Sprawdza, czy algorytm nie wybiera żadnych przedmiotów, gdy pojemność plecaka wynosi 0.
- **TestSpecificInstance**: Sprawdza, czy algorytm nie przekroczy pojemności plecaka i wybrany przedmiot nie przekroczy dopuszczalnej wagi.
- **TestKnapsackWithLargerCapacity**: Sprawdza działanie algorytmu z większą pojemnością plecaka (10).
- **TestMinKnapsackCapacity**: Sprawdza, czy algorytm działa poprawnie z minimalną pojemnością plecaka (1).

## Testy jednostkowe

Testy jednostkowe znajdują się w projekcie **`UnitTests`** i służą do sprawdzenia poprawności działania aplikacji. Poniżej przedstawiono kilka przykładowych testów:

### **Test 1: Test, czy rozwiązanie zawiera przynajmniej jeden przedmiot**

```
[TestMethod]
public void TestNonEmptySolution()
{
    Problem problem = new Problem(5, 42);
    Result result = problem.Solve(15);
    Assert.IsTrue(result.SelectedItems.Count > 0, "At least one item should be selected.");
}
```

### **Test 2: Test, czy rozwiązanie jest puste przy pojemności 0**
```
[TestMethod]
public void TestEmptySolution()
{
    Problem problem = new Problem(5, 42);
    Result result = problem.Solve(0);
    Assert.AreEqual(0, result.SelectedItems.Count, "No items should be selected when capacity is zero.");
}
```

### **Test 2: Test, czy rozwiązanie jest puste przy pojemności 0**
```
[TestMethod]
public void TestEmptySolution()
{
    Problem problem = new Problem(5, 42);
    Result result = problem.Solve(0);
    Assert.AreEqual(0, result.SelectedItems.Count, "No items should be selected when capacity is zero.");
}
```

### **Test 3: Testowanie dla określonej instancji**
```
[TestMethod]
public void TestSpecificInstance()
{
    Problem problem = new Problem(3, 1);
    Result result = problem.Solve(10);
    Assert.IsTrue(result.TotalWeight <= 10, "Total weight should not exceed capacity.");
}
```

### **Test 4: Test z większą pojemnością plecaka**
```
[TestMethod]
public void TestKnapsackWithLargerCapacity()
{
    Problem problem = new Problem(5, 42);
    Result result = problem.Solve(10);
    Assert.IsTrue(result.TotalWeight <= 10, "Total weight should not exceed the knapsack's capacity.");
    Assert.IsTrue(result.SelectedItems.Count > 0, "At least one item should be selected.");
}
```

### **Test 5: Test z minimalną pojemnością plecaka**
```
[TestMethod]
public void TestMinKnapsackCapacity()
{
    Problem problem = new Problem(3, 42);
    Result result = problem.Solve(1);
    Assert.IsTrue(result.SelectedItems.Count > 0, "At least one item should be selected.");
    Assert.IsTrue(result.TotalWeight <= 1, "Total weight should not exceed the knapsack's capacity of 1.");
}
```
