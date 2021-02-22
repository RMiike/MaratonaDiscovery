const localeStringValues = {
  locale: "pt-BR",
  styles: {
    style: "currency",
    currency: "BRL",
  },
};

export function toBRLString(entry) {
  if (entry === undefined) {
    return 0;
  }
  return entry.toLocaleString(
    localeStringValues.locale,
    localeStringValues.styles
  );
}
