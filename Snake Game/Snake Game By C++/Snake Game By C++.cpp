#include<stdio.h>
#include<stdlib.h>
#include<cstdlib>
#include<iostream>
#include<conio.h>
#include<Windows.h>
#include<dos.h>
#include<string>
#include<string.h>
#include <time.h>
#include<ctime>

#define up 0x48
#define down 0x50
#define left 0x4b
#define right 0x4d

void gotoxy(int x, int y);

void Draw(int x, int y, char Character);

using namespace std;

struct Point
{
public:
    int X_Position;
    int Y_Position;
};

class Node
{

private:
    Point CurrentPosition;
    Point PreviousPosition;
    Node* NextNode;
    Node* PreviousNode;

public:
    Node()
    {
        CurrentPosition.X_Position = 49;
        CurrentPosition.Y_Position = 13;
        PreviousPosition.X_Position = 48;
        PreviousPosition.Y_Position = 13;
        NextNode = nullptr;
        PreviousNode = nullptr;
        Draw(CurrentPosition.X_Position, CurrentPosition.Y_Position, '>');
    }

    ~Node()
    {

    }

    Node(Node* previous_ptr,Node* next_ptr)
    {
        PreviousNode = previous_ptr;
        NextNode = next_ptr;
    }

    void Set_Current_X_Position(int x)
    {
        CurrentPosition.X_Position = x;
    }

    void Set_Current_Y_Position(int y)
    {
        CurrentPosition.Y_Position = y;
    }

    void Set_Previous_X_Position(int x)
    {
        PreviousPosition.X_Position = x;
    }

    void Set_Previous_Y_Position(int y)
    {
        PreviousPosition.Y_Position = y;
    }

    int Get_Current_X_Position()
    {
        return CurrentPosition.X_Position;
    }

    int Get_Current_Y_Position()
    {
        return CurrentPosition.Y_Position;
    }

    int Get_Prevoius_X_Position()
    {
        return PreviousPosition.X_Position;
    }

    int Get_Prevoius_Y_Position()
    {
       return PreviousPosition.Y_Position;
    }

    void SetNextNodeAddress(Node* next_ptr)
    {
        NextNode = next_ptr;
    }

    void SetPreviousNodeAddress(Node* previous_ptr)
    {
        PreviousNode = previous_ptr;
    }

    Node* GetNextNodeAddress()
    {
        return NextNode;
    }

    Node* GetPreviousNodeAddress()
    {
       return PreviousNode;
    }
};

class Moves
{
public:
    Moves()
    {
           
    }

    ~Moves()
    {

    }

    void MoveUp(Node* node)
    {
        node->Set_Previous_X_Position(node->Get_Current_X_Position());
        node->Set_Previous_Y_Position(node->Get_Current_Y_Position());

        if (node->GetPreviousNodeAddress() == nullptr)
            Draw(node->Get_Current_X_Position(), node->Get_Current_Y_Position(), ' ');

        if (node->GetNextNodeAddress() == nullptr)
        {
            node->Set_Current_Y_Position(node->Get_Current_Y_Position() - 1);
            Draw(node->Get_Current_X_Position(), node->Get_Current_Y_Position(), '^');
        }
        else
        {
            node->Set_Current_X_Position(node->GetNextNodeAddress()->Get_Prevoius_X_Position());
            node->Set_Current_Y_Position(node->GetNextNodeAddress()->Get_Prevoius_Y_Position());
        }
    }

    void MoveDown(Node* node)
    {
        node->Set_Previous_X_Position(node->Get_Current_X_Position());
        node->Set_Previous_Y_Position(node->Get_Current_Y_Position());

        if (node->GetPreviousNodeAddress() == nullptr)
            Draw(node->Get_Current_X_Position(), node->Get_Current_Y_Position(), ' ');

        if (node->GetNextNodeAddress() == nullptr)
        {
            node->Set_Current_Y_Position(node->Get_Current_Y_Position() + 1);
            Draw(node->Get_Current_X_Position(), node->Get_Current_Y_Position(), 'v');
        }
        else
        {
            node->Set_Current_X_Position(node->GetNextNodeAddress()->Get_Prevoius_X_Position());
            node->Set_Current_Y_Position(node->GetNextNodeAddress()->Get_Prevoius_Y_Position());
        }
    }

    void MoveRight(Node* node)
    {
        node->Set_Previous_X_Position(node->Get_Current_X_Position());
        node->Set_Previous_Y_Position(node->Get_Current_Y_Position());

        if (node->GetPreviousNodeAddress() == nullptr)
            Draw(node->Get_Current_X_Position(), node->Get_Current_Y_Position(), ' ');

        if (node->GetNextNodeAddress() == nullptr)
        {
            node->Set_Current_X_Position(node->Get_Current_X_Position() + 1);
            Draw(node->Get_Current_X_Position(), node->Get_Current_Y_Position(), '>');
        }
        else
        {
            node->Set_Current_X_Position(node->GetNextNodeAddress()->Get_Prevoius_X_Position());
            node->Set_Current_Y_Position(node->GetNextNodeAddress()->Get_Prevoius_Y_Position());
        }
    }

    void MoveLeft(Node* node)
    {
        node->Set_Previous_X_Position(node->Get_Current_X_Position());
        node->Set_Previous_Y_Position(node->Get_Current_Y_Position());

        if (node->GetPreviousNodeAddress() == nullptr)
            Draw(node->Get_Current_X_Position(), node->Get_Current_Y_Position(), ' ');

        if (node->GetNextNodeAddress() == nullptr)
        {
            node->Set_Current_X_Position(node->Get_Current_X_Position() - 1);
            Draw(node->Get_Current_X_Position(), node->Get_Current_Y_Position(), '<');
        }
        else
        {
            node->Set_Current_X_Position(node->GetNextNodeAddress()->Get_Prevoius_X_Position());
            node->Set_Current_Y_Position(node->GetNextNodeAddress()->Get_Prevoius_Y_Position());
        }
    }
};

class PlayingEnvironment
{
private:
    int row;
    int column;
    int color = 0;
    
public:
    PlayingEnvironment()
    {
        for (row = 4; row < 24; row++)
        {
            for (column = 10; column < 100; column++)
            {
                SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), ((color % 15) + 1));
                if (row == 4 || row == 23)
                {
                    gotoxy(column, row);
                    cout << '*';
                    ++color;
                }
                else
                {
                    if (column == 10 || column == 99)
                    {
                        gotoxy(column, row);
                        cout << '*';
                        ++color;
                    }
                    else
                    {
                        gotoxy(column, row);
                        cout << " ";
                    }
                }
            }
            cout << endl;
        }
    }

    ~PlayingEnvironment()
    {

    }
};

class FruitFactory
{
private:
    Point FruitPosition;
    static int NumberOfEatenFruits;

public:
    FruitFactory()
    {
        Set_Fruit_X_Position(60);
        Set_Fruit_Y_Position(13);
        gotoxy(78, 2);
        cout << "Your Current Score : " << GetNumberOfEatenFruits();
        Draw(Get_Fruit_X_Position(), Get_Fruit_Y_Position(), 'Q');
    }

    ~FruitFactory()
    {

    }

    void Set_Fruit_X_Position(int x)
    {
        FruitPosition.X_Position = x;
    }

    void Set_Fruit_Y_Position(int y)
    {
        FruitPosition.Y_Position = y;
    }

    void SetNumberOfEatenFruits()
    {
        ++NumberOfEatenFruits;
    }

    int Get_Fruit_X_Position()
    {
        return FruitPosition.X_Position;
    }

    int Get_Fruit_Y_Position()
    {
        return FruitPosition.Y_Position;
    }

    int GetNumberOfEatenFruits()
    {
        return NumberOfEatenFruits;
    }

    void GenerateFruit(int Min_X_Border, int Max_X_Border, int Min_Y_Border, int Max_Y_Border) //min X=4 , max X=24 , min Y=10 , max Y=100
    {
       ++NumberOfEatenFruits;
       gotoxy(99, 2);
       cout<< GetNumberOfEatenFruits();

       Set_Fruit_X_Position(rand() % 100 + 1);
       Set_Fruit_Y_Position(rand() % 100 + 20);

       if (Get_Fruit_X_Position() <= Min_Y_Border)
           Set_Fruit_X_Position(Get_Fruit_X_Position() + (Min_Y_Border - Get_Fruit_X_Position()) + 11);

       if (Get_Fruit_X_Position() >= Max_Y_Border)
                Set_Fruit_X_Position(Get_Fruit_X_Position() - (Get_Fruit_X_Position() - Max_Y_Border)- 15);

       if (Get_Fruit_Y_Position() <= Min_X_Border)
                Set_Fruit_Y_Position(Get_Fruit_Y_Position() + (Min_X_Border - Get_Fruit_Y_Position()) + 17);

       if (Get_Fruit_Y_Position() >= Max_X_Border)
                Set_Fruit_Y_Position(Get_Fruit_Y_Position() - (Get_Fruit_Y_Position() - Max_X_Border) - 13);

       Draw(FruitPosition.X_Position, FruitPosition.Y_Position, 'Q');
    }
};

int FruitFactory::NumberOfEatenFruits = 0;

Node* CreateNode(Node* previous_ptr, Node* next_ptr);

void AddNode(Node* head);

int main()
{
    string name;
    gotoxy(46, 13);
    cout << "Please,Enter Your Name\n";
    gotoxy(46, 14);
    cin >> name;
    gotoxy(10, 2);
    cout << "current User : "<<name;
    PlayingEnvironment environment;
    FruitFactory fruit;
    char character;
    int Color;
    Color = 0;
    Moves move;
    Node* HeadNode;
    Node* Head;
    HeadNode = new Node();
    Head = HeadNode;
    int i;

    do
    {
        character = _getch();
        SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), ((Color%15)+1));
        switch (character)
        {
          case -32:
              character = _getch();
            switch (character)
            {
              case up:
                  while (HeadNode != nullptr)
                  {
                      if (HeadNode->GetNextNodeAddress() == nullptr)
                      {
                          if (HeadNode->Get_Current_X_Position() == fruit.Get_Fruit_X_Position()
                              && 
                              HeadNode->Get_Current_Y_Position() == fruit.Get_Fruit_Y_Position()
                             )
                          {
                              fruit.GenerateFruit(4, 24, 10, 100);
                              AddNode(Head);
                          }
                      }
                      move.MoveUp(HeadNode);
                      HeadNode = HeadNode->GetPreviousNodeAddress();
                  }
                  ++Color;
              break;

              case down:
                  while (HeadNode != nullptr)
                  {
                      if (HeadNode->GetNextNodeAddress() == nullptr)
                      {
                          if (HeadNode->Get_Current_X_Position() == fruit.Get_Fruit_X_Position()
                              &&
                              HeadNode->Get_Current_Y_Position() == fruit.Get_Fruit_Y_Position()
                              )
                          {
                              fruit.GenerateFruit(4, 24, 10, 100);
                              AddNode(Head);
                          }
                      }
                      move.MoveDown(HeadNode);
                      HeadNode = HeadNode->GetPreviousNodeAddress();
                  }
                  ++Color;
              break;

              case right:
                  while (HeadNode != nullptr)
                  {
                      if (HeadNode->GetNextNodeAddress()== nullptr)
                      {
                          if (HeadNode->Get_Current_X_Position() == fruit.Get_Fruit_X_Position()
                              && 
                              HeadNode->Get_Current_Y_Position() == fruit.Get_Fruit_Y_Position()
                             ) 
                          {
                              fruit.GenerateFruit(4, 24, 10, 100);
                              AddNode(Head);
                          }
                      }
                      move.MoveRight(HeadNode);
                      HeadNode = HeadNode->GetPreviousNodeAddress();
                  }
                  ++Color;
              break;

              case left:
                  while (HeadNode != nullptr)
                  {
                      if (HeadNode->GetNextNodeAddress() == nullptr)
                      {
                          if (HeadNode->Get_Current_X_Position() == fruit.Get_Fruit_X_Position()
                              && 
                              HeadNode->Get_Current_Y_Position() == fruit.Get_Fruit_Y_Position()
                             )
                          {
                              fruit.GenerateFruit(4, 24, 10, 100);
                              AddNode(Head);
                          }
                      }
                      move.MoveLeft(HeadNode);
                      HeadNode = HeadNode->GetPreviousNodeAddress();
                  }
                  ++Color;
              break;
            }
              HeadNode = Head;
          break;
        }
    } while((HeadNode->Get_Current_X_Position() > (10) && HeadNode->Get_Current_X_Position() < (99))
           &&
           (HeadNode->Get_Current_Y_Position() > (4) && HeadNode->Get_Current_Y_Position() < (23)));

    gotoxy(42,11);
    cout << "Game Over "<<name;
    cout << endl;
    cout << endl;
    gotoxy(42, 13);
    cout << name << ",Your Score Is " << fruit.GetNumberOfEatenFruits();
    gotoxy(42,28);

    return 0;
}

void gotoxy(int x, int y)
{
    COORD c;

    c.X = x - 1;
    c.Y = y - 1;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), c);
}

void Draw(int x, int y, char Character)
{
    gotoxy(x, y);
    _cprintf("%c", Character);
}

Node* CreateNode(Node* previous_ptr, Node* next_ptr)
{
    Node* NewNode = new Node(previous_ptr, next_ptr);
    return NewNode;
}

void AddNode(Node* head_node)
{
    Node* NewNode;

    while (head_node->GetPreviousNodeAddress()!=nullptr)
    {
        head_node = head_node->GetPreviousNodeAddress();
    }

    NewNode = CreateNode(nullptr, head_node);

    head_node->SetPreviousNodeAddress(NewNode);
    NewNode->Set_Current_X_Position(head_node->Get_Prevoius_X_Position());
    NewNode->Set_Current_Y_Position(head_node->Get_Prevoius_Y_Position());
    NewNode->Set_Previous_X_Position(NewNode->Get_Current_X_Position() - 1);
    NewNode->Set_Previous_Y_Position(NewNode->Get_Current_Y_Position());
}