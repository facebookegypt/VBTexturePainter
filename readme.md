# 🎨 VBTexturePainter

A lightweight VB.NET class library targeting **.NET Framework 4.8.1** that allows you to apply **procedural background textures**—such as dots and dashed grids—to any WinForms control without using external image files.

---

## 🚀 Key Features

- ✅ **Works on any WinForms control** with a `BackColor` property
- 🧩 **No subclassing needed** – just call the class at runtime
- ✴️ **Built-in textures**:
  - Dotted background
  - Dashed grid
- 🪶 **No image files** – purely procedural
- 🛠️ **Framework Support** – .NET Framework 4.8 / 4.8.1

---

## 🛠️ Getting Started

### 🔗 Clone the Repository

```bash
git clone https://github.com/yourusername/VBTexturePainter.git
```

### 🔧 Add to Your Project

- Add `TexturePainter.vb` to your WinForms project, or  
- Compile it into a class library and reference the DLL

### 🎯 Apply a Texture in Code

```vbnet
' Apply a dotted texture to a Panel
TexturePainter.ApplyDotTexture(Panel1, Color.Gray, 10)

' Apply a dashed grid to a Label
TexturePainter.ApplyDashGridTexture(Label1, Color.LightBlue, 20)
```

---

## 📁 Project Structure

```
VBTexturePainter/
├── TexturePainter.vb          ' Core class logic
├── Examples/
│   └── TextureDemoApp.sln     ' Demo solution file
│   └── Form1.vb               ' WinForms example usage
├── README.md                  ' Project documentation
├── LICENSE                    ' MIT license file
```

---

## 📚 API Reference

### `ApplyDotTexture`

```vbnet
Sub ApplyDotTexture(ctrl As Control, Optional dotColor As Color = Nothing, Optional spacing As Integer = 10)
```

Draws evenly spaced dots across the background of the control.

---

### `ApplyDashGridTexture`

```vbnet
Sub ApplyDashGridTexture(ctrl As Control, Optional lineColor As Color = Nothing, Optional spacing As Integer = 20)
```

Draws dashed vertical and horizontal lines to form a grid pattern.

---

## 🛤 Roadmap

- [ ] Add diagonal grid support
- [ ] Add noise and pixel-based pattern texture
- [ ] Package for NuGet

---

## 📄 License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

---

## 👤 Author

**[Your Name]**  
GitHub: [https://github.com/yourusername](https://github.com/yourusername)  
Upwork: [Your Upwork Profile URL]