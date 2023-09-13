# README

° Compare prices

°In questa software è possibile confrontare i vari prezzi di negozi che vendono dei monitor Philips.
Viene inserito un valore nella barra di testo,e grazie all'utilizzo del bottone invio si avviano  varie funzioni.
Il valore viene convertito in un intero per poi passare nei vari passaggi .
Ci sono 3 funzioni diverse per i tre negozi, esse si occupano di confrontare  il  numero di monitor richiesti
con i monitor disponibili nel negozio, se il numero dell'ordine rientra nella disponibilità del negozio allora 
moltiplica il numero richiesto per il prezzo e verifica se ci sono degli sconti disponibili in base al risultato 
del prezzo o in base alla quantità ordinata, nel caso in cui non ci fossero abbastanza scorte il programma comunica 
con un messaggio al cliente che non ci sono abbastanza scorte disponibili.Per quanto riguarda il terzo negozio
  é stato inserito un blocco di testo supplementare in modo da appurare se il mese corrente fa parte del periodo 
di saldo dell'azienda.Il mese inserito viene trasformato in una string e viene confrontata con un'altra string 
con il mese dello sconto in modo da verificare se i due valori sono i medesimi.
Dopo aver praticato questo procedimento per le varie funzioni,il risultato viene paraganoto con quello degli altri
 negozi ed evidenzia il prezzo  minore tramite il meccanismo "If" ,il risultato  viene diviso in due parti,
la prima parte è composta da un testo dove viene indicato di che negozio di tratta,il prezzo proposto 
ed il tempo di spedizione mentre il prezzo viene trasferito anche in un'altra tabella  in modo da evidenziare 
solo la tariffa migliore e non tutta la frase che specifica le caratteristiche nel negozio ,le caselle di testo 
 sono state nominate in modo che ogni risultato potesse andare nella propria postazione.
Prima di trasferire il valore viene convertito il valore int con una string,siccome non è stato possibile
 trasferire il risultato con la cosiddetta nomina .Per finire, all'inizio del meccanismo del bottone,
 viene reinizializzato il valore del numero evidenziato in modo da non trascinare il risultato precedente.
