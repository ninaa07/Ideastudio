import { ProjekatZaGradjevinskuDozvolu, StatusDokumenta } from './projekat-za-gradjevinsku-dozvolu.model';
import { VrstaPovrsine } from './vrsta-povrsine.model';

export class Povrsina {

    id: number;

    oznaka: number;

    vrstaPoda: string;

    projekatZaGradjevinskuDozvolu: ProjekatZaGradjevinskuDozvolu;

    vrstaPovrsine: VrstaPovrsine;

    status: Status;
}

export enum Status {

    Insert,

    Update,

    Delete
}