import { Component, OnInit, Inject } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-creature-detail',
  templateUrl: './creature-detail.component.html'
})
export class CreatureDetailComponent implements OnInit {
    creature;

    constructor(
        private route: ActivatedRoute,
        private http: HttpClient,
        @Inject('BASE_URL') private baseUrl: string
    ) { }

    ngOnInit() {
        this.route.paramMap.subscribe(params => {
            this.http.get<CreatureWithKin>(this.baseUrl + 'api/creatures/' + params.get('moniker')).subscribe(result => {
                this.creature = result;
            }, error => console.error(error));
        });
    }
}

interface CreatureWithKin {

    moniker: string;
    name: string;

    birthdate: string;

    parent1Moniker: string;
    parent1Name: string;

    parent2Moniker: string;
    parent2Name: string;

    childrenMonikers: [string];
    childrenNames: [string];
}
