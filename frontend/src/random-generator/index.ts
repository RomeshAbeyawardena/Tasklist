export enum CharacterGeneratorType {
    "uppercase",
    "lowercase",
    "numeric",
    "mixed"
}

export interface IRandomGeneratorOptions {
    mustStartWithAlphanumericCharacter: boolean;
    mayStartWithUppercase?: boolean;
    mayStartWithLowercase?: boolean;
}

export interface IRandomGenerator {
    generate(characterType: CharacterGeneratorType, length: number, options?: IRandomGeneratorOptions): string;
    generateCharacter(characterType: CharacterGeneratorType, options?: IRandomGeneratorOptions): string;
}

export class RandomGenerator implements IRandomGenerator {
    generate(characterType: CharacterGeneratorType, length: number,
        options?: IRandomGeneratorOptions): string {
        let s = "";

        while (s.length < length) {
            if (options != undefined
                && options.mustStartWithAlphanumericCharacter
                && s.length == 0) {
                s = s.concat(this.generateCharacter(CharacterGeneratorType.lowercase));
            }

            s = s.concat(this.generateCharacter(characterType));
        }

        return s;
    }

    generateCharacter(characterType: CharacterGeneratorType): string {
        let lowerBound = 0;
        let upperBound = 0;
        switch (characterType) {
            case CharacterGeneratorType.lowercase:
                lowerBound = 97;
                upperBound = 122;
                break;
            case CharacterGeneratorType.numeric:
                lowerBound = 49;
                upperBound = 57;
                break;
            case CharacterGeneratorType.uppercase:
                lowerBound = 65;
                upperBound = 90;
                break;
            case CharacterGeneratorType.mixed:
                const decider = this.getRandomNumber(1, 1000);
                let decidedCharacterType = CharacterGeneratorType.lowercase;
                if (decider < 250) {
                    decidedCharacterType = CharacterGeneratorType.uppercase;
                }
                else if (decider > 500) {
                    decidedCharacterType = CharacterGeneratorType.numeric;
                }

                return this.generateCharacter(decidedCharacterType);
        }

        return String.fromCharCode(this.getRandomNumber(lowerBound, upperBound));
    }

    getRandomNumber(min: number, max: number): number {
        return Math.floor(Math.random() * (max - min)) + min;
    }
}