import { InformacijeOLokaciji } from './informacije-o-lokaciji.model';
import { IdejnoResenje } from './idejno-resenje.model';

export class LokacijskaDozvola {

    id: number;

    brojParcele: number;

    povrsinaParcele: number;

    datumIzdavanja: Date;

    nazivObjekta: string;

    informacijeOLokaciji: InformacijeOLokaciji;

    idejnaResenja: IdejnoResenje[];
}