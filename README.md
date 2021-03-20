# Nullability and Pattern Matching

## Outline

- What is nullability and what are nullable reference types?
  - C# 8.0 introduces the nullable reference types feature. The nullable value types have been available beginning with C# 2. Why is this important?
    - What is the difference between nullable reference types and nullable value types?
- How to enable nullable in your dotnet proj.
- What is pattern matching

## Source code examples

- Why this:

```c
public string Text
        {
            get
            {
                if (string.IsNullOrEmpty(this._text))
                {
                    return string.Empty;
                }
                else
                {
#pragma warning disable CS8603
                    return this._text;
#pragma warning disable CS8603
                }
            }

            set
            {
                if (this._text != value)
                {
                    this._text = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Text)));
                }
            }
        }
```

- Can be simplified to this and is better:

```c
public string Text
        {
            get
            {
                return this._text is { } result ? result : string.Empty;
            }

            set
            {
                if (this._text != value)
                {
                    this._text = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Text)));
                }
            }
        }
```
