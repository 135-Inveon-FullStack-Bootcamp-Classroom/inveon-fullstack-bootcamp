const styles = {
  screenSection: {
    width: "100%",
    height: "30%",
    display: "flex",
    justifyContent: "center",
    flexDirection: "column",
    alignItems: "flex-end",
  },
  mainText: {
    color: "#fff",
    fontSize: 40,
    padding: 10,
    fontWeight: "bold",
  },
  caption: {
    color: "#999",
    fontSize: 13,
    paddingRight: 10,
  },
};

const ScreenSection = () => {
  return (
    <div style={styles.screenSection}>
      <span style={styles.caption}>25 +</span>
      <span style={styles.mainText}>5</span>
    </div>
  );
};

export default ScreenSection;
