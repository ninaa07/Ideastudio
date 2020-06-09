import { IdejnoResenje } from './idejno-resenje.model';
import { Povrsina } from './povrsina.model';

export class ProjekatZaGradjevinskuDozvolu {

    id: number;

    naziv: string;

    datumIzrade: Date;

    idejnoResenje: IdejnoResenje[];

    povrsine: Povrsina[];
}