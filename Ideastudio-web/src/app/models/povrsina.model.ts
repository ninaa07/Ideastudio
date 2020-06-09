import { ProjekatZaGradjevinskuDozvolu, StatusDokumenta } from './projekat-za-gradjevinsku-dozvolu.model';
import { VrstaPovrsine } from './vrsta-povrsine.model';

export class Povrsina {

    id: number;

    oznaka: number;

    vrstaPoda: string;

    projekatZaGradjevinskuDozvoluId: number;

    vrstaPovrsineId: number;

    status: Status;
}

export enum Status {

    Insert,

    Update,

    Delete
}