import { ProjekatZaGradjevinskuDozvolu } from './projekat-za-gradjevinsku-dozvolu.model';
import { VrstaPovrsine } from './vrsta-povrsine.model';

export class Povrsina {

    id: number;

    oznaka: number;

    vrstaPoda: string;

    projekatZaGradjevinskuDozvolu: ProjekatZaGradjevinskuDozvolu;

    vrstaPovrsine: VrstaPovrsine;
}