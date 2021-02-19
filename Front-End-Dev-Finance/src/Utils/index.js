const localeStringValues = {
  locale: "pt-BR",
  styles: {
    style: "currency",
    currency: "BRL",
  },
};

export function toBRLString(entry) {
  return entry.toLocaleString(
    localeStringValues.locale,
    localeStringValues.styles
  );
}
