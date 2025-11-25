🎨 Van Gogh Gallery App (.NET MAUI)

A cross-platform mobile application developed with .NET 9.0 MAUI that showcases a responsive, interactive profile and art gallery for Vincent van Gogh.

✨ Features

This application implements advanced UI techniques and meets specific layout requirements:

1. 👤 Floating Profile Interface

Rounded Profile Picture: Implemented a perfect circle profile image using Border stroke shaping.

Floating Effect: The profile picture sits on the boundary of the background and the content card using Grid overlapping and negative margins.

Status: ✅ Requirement Fulfilled.

2. 📖 Interactive Biography

Expandable Text: Features a "Read More" / "Read Less" toggle.

Tail Truncation: Automatically truncates text with ellipses (...) when collapsed and wraps fully when expanded.

Implementation: Custom MVVM logic (boolean triggers) without external dependencies.

Status: ✅ Requirement Fulfilled.

3. 📊 Responsive Stats Grid

Equal Width Layout: Uses a Grid with ColumnDefinitions="*,*,*,*" to ensure the four statistic columns (Record, Average, General, Items) share equal width on any screen size.

No Hardcoded Margins: Spacing is handled dynamically by the Grid structure.

Status: ✅ Requirement Fulfilled.

4. 🖼️ Masonry Art Gallery

Staggered Layout: Implemented a Pinterest-style "Masonry" layout where images of different heights (Portrait vs. Landscape) fit perfectly without gaps.

Structure: utilized a 2-Column Grid with independent VerticalStackLayouts inside a ScrollView.

Status: ✅ Requirement Fulfilled.

🛠️ Tech Stack

Framework: .NET 9.0 MAUI

Language: C#

Pattern: MVVM (Model-View-ViewModel)

UI: XAML (Hand-coded grids and layouts)

🚀 How to Run

Clone the repository:

git clone [https://github.com/YOUR_USERNAME/VanGogh-Gallery-MAUI.git](https://github.com/YOUR_USERNAME/VanGogh-Gallery-MAUI.git)


Open in Visual Studio 2022.

Restore Nuget Packages:
The project uses standard MAUI libraries.

Run:
Select your target (Android Emulator or Windows Machine) and press F5.

📂 Project Structure

MainPage.xaml - Contains the entire UI layout (Floating Profile, Header, Masonry Grid).

ViewModels/ProfileViewModel.cs - Handles data binding, the artwork collection, and the "Read More" logic.

Resources/Images - Contains high-quality assets (Portrait and Landscape paintings).

Developed for .NET MAUI Progress Test
