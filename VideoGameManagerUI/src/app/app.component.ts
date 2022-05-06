import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

export interface GameGenre {
  id: number;
  name: string;
}

export interface Game {
  id: number;
  name: string;
  personalRating: number;
  genre: GameGenre;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'VideoGameManagerUI';
  public games: Game[] = [];

  constructor(private client: HttpClient) {}
  // This is the method, that is called, when the component is initialized.
  // this is a good place to retrieve data from the server.
  ngOnInit() {
    this.client
      .get<Game[]>('https://localhost:5001/Game')
      .subscribe((result) => (this.games = result));
  }
}
