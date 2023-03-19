import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TicTacToeService {
  boardSize: number = 9;

  board: Symbol[] = [];

  activePlayer: Symbol = Symbol.X;

  isGoing: boolean = false;

  winner: Symbol = Symbol.None;


  constructor() {
    this.board = this.createBoard()
  }

  createBoard(): Symbol[] {
    let board: Symbol[] = [];

    for (let i = 0; i < 9; i++) {
      board.push(Symbol.None);
    }

    return board;
  }


  public checkRows(): boolean {
    for (let i = 0; i < 3; i++){
        let
          firstSquare = this.board[i],
          secondSquare = this.board[i + 3],
          thirdSquare = this.board[i + 6];

        if (firstSquare && secondSquare && thirdSquare){
          if (firstSquare == secondSquare && secondSquare == thirdSquare){
            this.winner = this.activePlayer
            return true
          }
        }
    }
    return false
  }

  public checkDiag(): boolean {
    let middleSquare = this.board[4]

    for (let i = 0; i < 2; i+=2){
      let lowerSquare = this.board[i],
        upperSquare = this.board[8 - i];

      if (lowerSquare && upperSquare && middleSquare) {
        if (lowerSquare == upperSquare && upperSquare == middleSquare) {
          this.winner = this.activePlayer
          return true
        }
      }
    }
    return false
  }

  public checkColumns(): boolean {
    for (let i = 0; i < 6; i+=3){
      for (let j = i; i < i+3; i++){
        let firstSquare = this.board[j],
          secondSquare = this.board[j]
      }
    }
  }

  public newGame(): void {

  }
}

export enum Symbol {
  None,
  X,
  O
}
