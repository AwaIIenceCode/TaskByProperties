# TaskByProperties
A C# console app to practice OOP encapsulation through different types of properties. Each branch focuses on a specific property type, with game-themed classes like inventory items, achievements, and loggers.
# 📖 About
TaskManager is a learning project to master C# properties and encapsulation. It includes:

InventoryItem (full properties with validation).
Achievement (auto-implemented properties).
Logger (write-only properties).
Built to reinforce OOP basics in a fun, game-inspired way, with a focus on clean code and validation.

# 🚀 Features

InventoryItem: Manages game items (e.g., Wood, Iron) with validated quantity (0–64, Minecraft-style stack).
Achievement: Tracks player achievements with simple auto-properties for title and unlock status.
Logger: Logs game events (e.g., "Player defeated enemy") using write-only properties.
Input Validation: Ensures non-empty names and valid ranges where needed.
Clean Output: Displays item, achievement, or log details in a readable format.

# 🛠️ How It Works

Each class is in a separate branch (full-properties, auto-properties, write-only-properties).
Create objects, set properties, and print details via console methods.
Example classes mimic game mechanics (inventory, achievements, logs).

# 📋 Example Usage
InventoryItem (full-properties branch):

Item: Wood, Quantity: 64

Item: Iron, Quantity: 48

Item: Diamonds, Quantity: 12

Achievement (auto-properties branch):Achievement: First Kill, Unlocked: Yes

Achievement: Explorer, Unlocked: No

Achievement 'Explorer' unlocked!

Achievement: Explorer, Unlocked: Yes

Logger (write-only-properties branch):

Player joined the game

Player defeated enemy

Game saved

Logs cleared!

# 💻 Installation
1 - Clone the repo: ```git clone https://github.com/AwaIIenceCode/TaskByProperties.git```

2 - Checkout the desired branch (e.g., git checkout full-properties).

3 - Open in your IDE (Visual Studio, Rider, etc.).

4 - Run in a C# environment (.NET Core or later).
