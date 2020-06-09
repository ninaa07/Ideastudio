import { LokacijskaDozvola } from './lokacijska-dozvola.model';

export class InformacijeOLokaciji {

    id: number;

    datumIzdavanja: Date;

    namenaZemljista: string;

    zona: string;

    lokacijskeDozvole: LokacijskaDozvola[];
}