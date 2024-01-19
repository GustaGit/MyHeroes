export class Hero {
    id: number;
    name: string;
    nameHero: string;
    superpowers: SupePower[];
    birthdate?: Date;
    height: number;
    weight: number;
}

export class SupePower {
    id:number;
    superPower:string;
    description:string;
}