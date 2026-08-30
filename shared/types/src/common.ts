export type Identifier = number | string;

export interface IImage {
  alt?: string;
  src: string;
}

export interface ILink {
  href: string;
  isExternal?: boolean;
  name: string;
}

export type Nullable<T> = T | null;
