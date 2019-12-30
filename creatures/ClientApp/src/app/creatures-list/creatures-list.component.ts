import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-creatures-list',
  templateUrl: './creatures-list.component.html',
  styleUrls: ['./creatures-list.component.css']
})

export class CreaturesListComponent {
  public forecasts: WeatherForecast[];

  constructor(http: HttpClient) {
    http.get<WeatherForecast[]>('https://lemurware.tech/' + 'api/v1/creatures').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }

  timeUtcString(timeUtc: number): string {
      let date = new Date(timeUtc * 1000)
      return date.toLocaleString();
  }
}

interface WeatherForecast {

    moniker: string;
    name: string;

    birthEventType: BirthEventType;

    birthdate: string;

    parent1Moniker: string;
    parent1Name: string;

    parent2Moniker: string;
    parent2Name: string;

    birthWorldName: string;
    birthWorldId: string;

    children: [Child];

    photo: string;
}

interface Child {
    moniker: string;
    name: string;
}

enum BirthEventType {
    Conceived = 0,
    Spliced = 1,
    Engineered = 2,
    Cloned = 14,
}