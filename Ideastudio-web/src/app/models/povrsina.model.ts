export class Povrsina {

    id: number;

    oznaka: number;

    naziv: string;

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