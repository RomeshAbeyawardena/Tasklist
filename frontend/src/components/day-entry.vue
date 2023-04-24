<script setup lang="ts">
import "../scss/day-entry.scss";

import AutoComplete from 'primevue/autocomplete';
import TextArea from 'primevue/textarea';
import { createMainStore } from "../stores";
import { storeToRefs } from "pinia";
import { Entry } from '../models/entry';

import { CharacterGeneratorType, RandomGenerator } from "../random-generator";
import { ref, onBeforeMount } from "vue";

const projectElementId = ref("");
const clientElementId = ref("");
const notesElementId = ref("");
const mainStore = createMainStore();
const { isReadOnly } = storeToRefs(mainStore);

const props = defineProps({
    defaultReadOnlyClassName: String,
    entry: Entry
})

function setIds() {
    const rg = new RandomGenerator();
    projectElementId.value = rg.generate(CharacterGeneratorType.mixed, 6, {
        mustStartWithAlphanumericCharacter: true
    });
    clientElementId.value = rg.generate(CharacterGeneratorType.mixed, 6, {
        mustStartWithAlphanumericCharacter: true
    });
    notesElementId.value = rg.generate(CharacterGeneratorType.mixed, 6, {
        mustStartWithAlphanumericCharacter: true
    });
}

onBeforeMount(() => {
    setIds();
});

function setReadOnlyClass(className: string, readOnlyClassName?: string): string {
    const DEFAULT_CLASS_NAME = props.defaultReadOnlyClassName ?? "readonly";
    if (isReadOnly) {
        return className.concat(" ", readOnlyClassName ?? DEFAULT_CLASS_NAME.toString());
    }
    else
        return className;
}
</script>
<template>
    <div class="day-entry" v-if="props.entry">
        <div :class="setReadOnlyClass('client-entry')">
            <AutoComplete :input-id="clientElementId" v-model="props.entry.client" placeholder="Client"
                v-if="!isReadOnly" />
            <span v-if="isReadOnly">
                {{ props.entry?.client }}
            </span>
        </div>
        <div :class="setReadOnlyClass('project-entry')">
            <AutoComplete :input-id="projectElementId" v-model="props.entry.project" placeholder="project"
                v-if="!isReadOnly" />
            <span v-if="isReadOnly">
                {{ props.entry?.project }}
            </span>
        </div>
        <div :class="setReadOnlyClass('notes-entry')">
            <TextArea :id="notesElementId" v-if="!isReadOnly" v-model="props.entry.notes" placeholder="Notes" />
            <span v-if="isReadOnly">
                {{ props.entry?.notes }}
            </span>
        </div>
    </div>
</template>