# TrisGame 🎮

A console-based Tic Tac Toe game built in C# featuring an intelligent AI opponent using the minimax algorithm.

## 📝 Description

TrisGame is a classic Tic Tac Toe implementation that pits human players against an unbeatable AI computer opponent. The game features a clean console interface, strategic AI gameplay, and follows object-oriented programming principles with a well-structured codebase.

The AI opponent uses the minimax algorithm to calculate the optimal move for every game state, making it virtually impossible to beat - the best outcome a human player can achieve is a tie.

## ✨ Features

- **Human vs Computer gameplay** - Play against an intelligent AI opponent
- **Unbeatable AI** - Computer uses minimax algorithm for optimal play
- **Clean console interface** - Clear board visualization and user prompts
- **Input validation** - Robust handling of invalid moves and inputs
- **Replay functionality** - Option to play multiple rounds
- **Real-time feedback** - Visual indicators for AI thinking and move selection

## 🏗️ Architecture

The project follows a clean, modular architecture with separation of concerns:

### Core Components

- **`Game`** - Main game controller managing rounds and player turns
- **`Board`** - Game state management and board operations
- **`IPlayer`** - Interface defining player contract
- **`Human`** - Human player implementation with console input
- **`Computer`** - AI player with minimax algorithm
- **`Move`** - Data structure representing a game move

### Design Patterns Used

- **Strategy Pattern** - `IPlayer` interface allows different player types
- **Template Method** - Common game flow with specialized player behaviors
- **Model-View separation** - Game logic separated from console presentation

## 🚀 Getting Started

### Prerequisites

- .NET 6.0 or later
- C# compiler

### Installation

1. Clone the repository:
```bash
git clone <repository-url>
cd TrisGame
```

2. Build the project:
```bash
dotnet build
```

3. Run the game:
```bash
dotnet run
```

## 🎯 How to Play

1. The game starts with a 3x3 empty board
2. Human player uses 'X' symbols, Computer uses 'O' symbols
3. Human player goes first
4. Enter row and column coordinates (0-2) when prompted
5. The AI will automatically make its move after thinking
6. First player to get three symbols in a row (horizontal, vertical, or diagonal) wins
7. If the board fills without a winner, the game is a tie

### Input Format

When it's your turn, enter coordinates as two numbers separated by a space:
```
Player X - enter row and column (0-2): 1 1
```

Board positions are numbered 0-2 for both rows and columns:
```
0,0 | 0,1 | 0,2
----|-----|----
1,0 | 1,1 | 1,2
----|-----|----
2,0 | 2,1 | 2,2
```

## 🤖 AI Strategy

The computer opponent implements the **minimax algorithm** with the following characteristics:

- **Perfect play** - Always chooses the mathematically optimal move
- **Depth-aware scoring** - Prefers quicker wins and longer losses
- **Exhaustive search** - Evaluates all possible future game states
- **Alpha-beta optimization** potential for future enhancement

## 📁 Project Structure

```
TrisGame/
├── API/
│   └── IPlayer.cs          # Player interface definition
├── Action/
│   └── Move.cs             # Move data structure
├── Players/
│   ├── Human.cs            # Human player implementation
│   └── Computer.cs         # AI player with minimax
├── UI/
│   └── Board.cs            # Board representation and display
├── Game.cs                 # Main game controller
└── Program.cs              # Application entry point
```

## 🛠️ Technical Details

### Key Classes

**Board**
- Manages 3x3 game grid
- Provides move validation
- Detects win conditions and board state
- Handles board visualization

**Computer (AI Player)**
- Implements minimax algorithm
- Evaluates all possible game outcomes
- Scores positions based on win/loss/tie
- Includes depth preference for optimal timing

**Game Controller**
- Manages game flow and player turns
- Handles win/tie detection
- Provides replay functionality
- Coordinates UI updates

### Algorithm Complexity

- **Time Complexity**: O(3^n) where n is the number of empty cells
- **Space Complexity**: O(n) for recursion depth
- **Game Tree Size**: Maximum ~550,000 nodes for full game analysis

## 🔧 Customization

The modular design allows for easy extensions:

- **Add new player types** by implementing `IPlayer`
- **Modify board size** by adjusting the Board class constants
- **Enhance AI difficulty** by adding randomness or time limits
- **Improve UI** by adding colors or better formatting

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

**Enjoy playing against the unbeatable AI! 🤖**
